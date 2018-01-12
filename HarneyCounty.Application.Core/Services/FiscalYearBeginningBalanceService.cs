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
                var result = new FiscalYearBeginningBalanceViewModel();

                result.YtdCollections = Math.Abs(dailyDetailData.Sum(t => t.NetTaxCr));
                result.YtdGains = dailyDetailData.Sum(t => t.GainsToRoll ?? 0);
                result.YtdLosses = dailyDetailData.Sum(t => t.LossesToRoll ?? 0);
                result.Year = dailyDetailyear;
                result.AuditFiscalYearId = fiscalYearId;
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
    }
}