﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ApiRest.Model;
using ApiRest.Model.Context;

namespace ApiRest.Business.Implementations
{
    public class PersonBusinessImpl : IPersonBusiness // extends
        {

            private readonly IPersonRepository _repository;

            public PersonBusinessImpl(IPersonRepository repository)
            {
                _repository = repository;
            }

            public Person Create(Person person)
            {
                return _repository.Create(person);
            }

            public Person FindById(long id)
            {
                return _repository.FindById(id);
            }

            public List<Person> FindAll()
            {
                return _repository.FindAll();
            }

            public Person Update(Person person)
            {
                return _repository.Update(person);
            }

            public void Delete(long id)
            {
                _repository.Delete(id);
            }

            public bool Exists(long id)
            {
                return _repository.Exists(id);
            }
        }
    }
