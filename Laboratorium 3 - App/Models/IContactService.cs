﻿namespace Laboratorium_3___App.Models
{
    public interface IContactService
    {
        void Add(Contact contact);
        void Update(Contact contact);
        void DeleteById(int id);
        Contact? FindByID(int id);
        List<Contact> FindAll();
    }
}
