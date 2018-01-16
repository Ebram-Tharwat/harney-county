using AutoMapper;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel.Audit;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Application.Core.Services
{
    public class FiscalYearBeginningBalanceService : IFiscalYearBeginningBalanceService
    {
        private readonly IFiscalYearBeginningBalanceRepository _fiscalYearBeginningBalanceRepository;
        private readonly IAuditService _auditService;
        private readonly IUnitOfWork _uow;

        public FiscalYearBeginningBalanceService(IFiscalYearBeginningBalanceRepository fiscalYearBeginningBalanceRepository, IAuditService auditService, IUnitOfWork uow)
        {
            this._fiscalYearBeginningBalanceRepository = fiscalYearBeginningBalanceRepository;
            this._auditService = auditService;
            this._uow = uow;
        }

        public List<FiscalYearBeginningBalanceViewModel> GetByFiscalYearId(int fiscalYearId)
        {
            var data = _fiscalYearBeginningBalanceRepository.GetAll(fiscalYearId).ToList();
            return Mapper.Map<List<FiscalYearBeginningBalance>, List<FiscalYearBeginningBalanceViewModel>>(data);
        }

        public FiscalYearBeginningBalanceViewModel GetById(int id)
        {
            return Mapper.Map<FiscalYearBeginningBalance, FiscalYearBeginningBalanceViewModel>(_fiscalYearBeginningBalanceRepository.GetById(id));
        }

        public FiscalYearBeginningBalanceViewModel GetByFiscalYearIdAndDailyDetailYear(int fiscalYearId, int dailyDetailyear)
        {
            var dailyDetailData = _auditService.GetAllDailyDetailByFiscalYearId(fiscalYearId, dailyDetailyear);
            if (dailyDetailData.Any())
            {
                var result = ConvertDailyDetailIntoBeginningBalance(dailyDetailData, fiscalYearId);
                return result;
            }
            else
            {
                return null;
            }
        }

        public FiscalYearBeginningBalance Add(FiscalYearBeginningBalance entity)
        {
            this._fiscalYearBeginningBalanceRepository.Add(entity);
            _uow.Commit();

            return entity;
        }

        public List<FiscalYearBeginningBalanceViewModel> RepopulateFiscalYearBeginningBalancesByFiscalYearId(int fiscalYearId)
        {
            var dailyDetailData = _auditService.GetAllDailyDetailByFiscalYearId(fiscalYearId);
            if (dailyDetailData.Any())
            {
                var existedEntities = this._fiscalYearBeginningBalanceRepository.GetAll(fiscalYearId).ToList();
                dailyDetailData.GroupBy(t => t.TaxYear).ToList().ForEach(taxYearGroup =>
                {
                    var dailyDetailEntity = ConvertDailyDetailIntoBeginningBalance(taxYearGroup.ToList(), fiscalYearId);
                    var existedEntity = existedEntities.FirstOrDefault(t => t.Year == taxYearGroup.Key);
                    if (existedEntity == null)
                    {
                        var newEntity = Mapper.Map<FiscalYearBeginningBalanceViewModel, FiscalYearBeginningBalance>(dailyDetailEntity);
                        this._fiscalYearBeginningBalanceRepository.Add(newEntity);
                    }
                    else
                    {
                        existedEntity.YtdCollections = dailyDetailEntity.YtdCollections;
                        existedEntity.YtdGains = dailyDetailEntity.YtdGains;
                        existedEntity.YtdLosses = dailyDetailEntity.YtdLosses;
                        this._fiscalYearBeginningBalanceRepository.Update(existedEntity);
                    }
                });

                _uow.Commit();
            }
            return Mapper.Map<List<FiscalYearBeginningBalance>, List<FiscalYearBeginningBalanceViewModel>>(null); ;
        }

        public FiscalYearBeginningBalanceViewModel RepopulateFiscalYearBeginningBalance(int entityId)
        {
            var existedEntity = this.GetById(entityId);
            if (existedEntity != null)
            {
                var dailyDetailEntity = GetByFiscalYearIdAndDailyDetailYear(existedEntity.AuditFiscalYearId, existedEntity.Year.Value);
                if (dailyDetailEntity != null)
                {
                    existedEntity.YtdCollections = dailyDetailEntity.YtdCollections;
                    existedEntity.YtdGains = dailyDetailEntity.YtdGains;
                    existedEntity.YtdLosses = dailyDetailEntity.YtdLosses;
                    this.Update(existedEntity);
                }
                return existedEntity;
            }
            else
            {
                throw new NullReferenceException($"Couldn't find Beginning Balance with id= {entityId}");
            }
        }

        public void Update(FiscalYearBeginningBalanceViewModel viewmodel)
        {
            var entity = this._fiscalYearBeginningBalanceRepository.GetById(viewmodel.Id);
            if (entity == null)
            {
                throw new NullReferenceException("Cannot find FiscalYearBeginningBalance with Id=" + viewmodel.Id);
            }
            Mapper.Map(viewmodel, entity);
            this._fiscalYearBeginningBalanceRepository.Update(entity);
            _uow.Commit();
        }

        public void Remove(int id)
        {
            this._fiscalYearBeginningBalanceRepository.Delete(id);
            _uow.Commit();
        }

        #region Helpers

        private FiscalYearBeginningBalanceViewModel ConvertDailyDetailIntoBeginningBalance(List<AuditDailyDetailViewModel> dailyDetailData, int fiscalYearId)
        {
            var entity = new FiscalYearBeginningBalanceViewModel();
            entity.Year = dailyDetailData.FirstOrDefault().TaxYear;
            entity.BeginningBalance = 0;
            entity.YtdCollections = dailyDetailData.Sum(t => t.NetTaxCr);
            entity.YtdGains = dailyDetailData.Sum(t => t.GainsToRoll ?? 0);
            entity.YtdLosses = dailyDetailData.Sum(t => t.LossesToRoll ?? 0);
            entity.AuditFiscalYearId = fiscalYearId;

            return entity;
        }

        #endregion Helpers
    }
}