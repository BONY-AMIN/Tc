﻿using Tc.Domain.Models;

using Tc.Domain.Repositories;
using Tc.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tc.Core.Services
{
    public class BillingService
    {
        private UnitOfWork unitOfWork;

        public BillingService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public void Create(BillingViewModel billingVM)
        {
            var Billing = new Billing
            {

                BillNo = billingVM.BillNo,
                Date = billingVM.Date,
                JobId = billingVM.JobId,
                AccountId = billingVM.AccountId,
                TypeId = billingVM.TypeId,
                Amount = billingVM.Amount
            };

            unitOfWork.BillingRepository.Insert(Billing);
            unitOfWork.Save();
        }

        public void Update(BillingViewModel billingVM)
        {
            var Billing = new Billing
            {
                Id = billingVM.Id,
                BillNo = billingVM.BillNo,
                Date = billingVM.Date,
                JobId = billingVM.JobId,
                AccountId = billingVM.AccountId,
                TypeId = billingVM.TypeId,
                Amount = billingVM.Amount
            };


            unitOfWork.BillingRepository.Update(Billing);

            unitOfWork.Save();
        }


        public BillingViewModel GetByID(int id)
        {
            var data = (from s in unitOfWork.BillingRepository.Get()
                        where s.Id == id
                        select new BillingViewModel
                        {
                            Id = s.Id,
                            BillNo = s.BillNo,
                            Date = s.Date,
                            JobId = s.JobId,
                            AccountId = s.AccountId,
                            TypeId = s.TypeId,
                            Amount = s.Amount


                        }).SingleOrDefault();

            return data;
        }

        public IEnumerable<BillingViewModel> GetAll()
        {
            var data = (from s in unitOfWork.BillingRepository.Get()
                        select new BillingViewModel
                        {
                            Id = s.Id,
                            BillNo = s.BillNo,
                            Date = s.Date,
                            JobId = s.JobId,
                            AccountId = s.AccountId,
                            TypeId = s.TypeId,
                            Amount = s.Amount

                        }).AsEnumerable();

            return data;
        }

    }
}
