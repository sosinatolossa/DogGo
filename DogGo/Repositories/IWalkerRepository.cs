using DogGo.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IWalkerRepository
    {
        List<Walker> GetAllWalkers(); //define a list type walker GetAllWalkers() method
        Walker GetWalkerById(int id); //define a Walker type GetWalkerById() method that takes an id
    }
}
