﻿using DogGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners(); //define a list type owner GetAllOwners() method
        Owner GetOwnerById(int id); //define a Owner type GetOwnerById() method that takes an id
        Owner GetOwnerByEmail(string email);
        Owner AddOwner(Owner owner);
        Owner UpdateOwner(Owner owner);
        Owner DeleteOwner(Owner owner);
    }
}