﻿using AutoMapper;
using BLL.DTOs;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF.Model;

namespace BLL.Services
{
    public class LoanService
    {
        public static LoanDTO AddLoan(LoanDTO Loan)
        {
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<LoanService, Loan>();
                c.CreateMap<Loan, LoanService>();
            });
            var mapper = new Mapper(cfg);
            var data = mapper.Map<Loan>(Loan);
            var rt = DataAccessFactory.LoanDataAccess().Add(data);
            if (rt != null)
            {
                return mapper.Map<LoanDTO>(rt);
            }
            return null;
        }
        public static List<LoanDTO> Get()
        {
            var data = DataAccessFactory.LoanDataAccess().Get();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Loan, LoanDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<List<LoanDTO>>(data);
        }
        public static LoanDTO Get(int id)
        {
            var data = DataAccessFactory.LoanDataAccess().Get(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Loan, LoanDTO>();
            });
            var mapper = new Mapper(cfg);
            return mapper.Map<LoanDTO>(data);
        }
        public static LoanDTO Delete(int id)
        {
            var rt = DataAccessFactory.LoanDataAccess().Delete(id);
            if (rt != null)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Loan, LoanDTO>();
                });
                var mapper = new Mapper(config);
                var dbLoan = mapper.Map<LoanDTO>(rt);
                return dbLoan;
            }
            return null;
        }
        public static LoanDTO Update(LoanDTO Loan)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<LoanDTO, Loan>();
                cfg.CreateMap<Loan, LoanDTO>();
            });
            var mapper = new Mapper(config);
            var dbLoan = mapper.Map<Loan>(Loan);
            var rt = DataAccessFactory.LoanDataAccess().Update(dbLoan);
            if (rt != null)
            {
                return mapper.Map<LoanDTO>(rt);
            }
            return null;
        }
    }
}
