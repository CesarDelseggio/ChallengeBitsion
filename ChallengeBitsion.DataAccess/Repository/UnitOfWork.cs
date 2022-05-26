﻿using ChallengeBitsion.DataAccess.Data.Models;
using ChallengeBitsion.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeBitsion.DataAccess.Repository
{
    public class UnitOfWork
    {
        private AppDbContext _context;

        public UnitOfWork(AppDbContext contex)
        {
            _context = contex;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        private IRepository<Log> _logRepository;
        public IRepository<Log> LogRepository
        {
            get {
                if (_logRepository == null)
                    _logRepository = new Repository<Log>(_context);

                return _logRepository; 
            }
        }

        private IRepository<Gender> _genderRepository;
        public IRepository<Gender> GenderRepository
        {
            get
            {
                if (_genderRepository == null)
                    _genderRepository = new Repository<Gender>(_context);

                return _genderRepository;
            }
        }

        private IRepository<Client> _clientRepository;
        public IRepository<Client> ClientRepository
        {
            get
            {
                if (_clientRepository == null)
                    _clientRepository = new Repository<Client>(_context);

                return _clientRepository;
            }
        }
    }
}
