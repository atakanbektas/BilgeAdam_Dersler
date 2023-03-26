using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Wfa_KisiRehberi_DbFirst_EF.Models;

namespace Wfa_KisiRehberi_DbFirst_EF.Func
{
    public static class ContactFunc
    {
        public static KisiRehberiDBContext _db = new KisiRehberiDBContext();
        public static void ShowDgv(this DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = _db.Contacts.Select(contact => new
            {
                Ad = contact.FirstName,
                Soyad = contact.LastName,
                Tel = contact.PhoneNumber
            }).OrderByDescending(c => c.Soyad).OrderBy(c => c.Ad).ToList();
        }

        public static void ShowDgvAccordingName(this DataGridView dgv, string name)
        {
            dgv.DataSource = null;
            dgv.DataSource = _db.Contacts.Where(cont => cont.FirstName.Contains(name)).ToList();
        }
        public static void ShowDgvAccordingSurname(this DataGridView dgv, string surname)
        {
            dgv.DataSource = null;
            dgv.DataSource = _db.Contacts.Where(cont => cont.LastName.Contains(surname)).ToList();
        }
        public static void ShowDgvAccordingPhone(this DataGridView dgv, string phone)
        {
            dgv.DataSource = null;
            dgv.DataSource = _db.Contacts.Where(cont => cont.PhoneNumber.Contains(phone)).ToList();
        }
        public static void ShowDgvByAll(this DataGridView dgv, string findWord)
        {
            dgv.DataSource = null;
            dgv.DataSource = _db.Contacts.Where(cont =>
            cont.FirstName.Contains(findWord) ||
            cont.LastName.Contains(findWord) ||
            cont.PhoneNumber.Contains(findWord)).Select(cont => new
            {
                Ad = cont.FirstName,
                Soyad = cont.LastName,
                Tel = cont.PhoneNumber
            }).OrderByDescending(c => c.Soyad).OrderBy(c => c.Ad).ToList();


        }

        public static void DbSave()
        {
            _db.SaveChanges();
        }
        public static void Add(string firstName, string lastName, string phoneNumber)
        {
            _db.Contacts.Add(new Contact 
            { 
                FirstName = firstName, 
                LastName = lastName, 
                PhoneNumber = phoneNumber 
            });
        }
        public static void DeleteById(int id)
        {
            var deleteContact = _db.Contacts.Where(c => c.Id==id).FirstOrDefault();
            _db.Contacts.Remove(deleteContact);
        }
        public static void DeleteByContact(Contact contact)
        {
            _db.Contacts.Remove(contact);
        }
        public static void UpdateById(int id, string newFirstName, string newLastName, string newPhone)
        {
            var updateContact = _db.Contacts.Where(c => c.Id == id).FirstOrDefault();
            updateContact.FirstName = newFirstName;
            updateContact.LastName = newLastName;
            updateContact.PhoneNumber = newPhone;
        }

        public static int GetIndex(this DataGridView dgvPhone,int indexSelectedRow)
        {
            return dgvPhone.SelectedRows[indexSelectedRow].Index;
        }
        public static List<Contact> ToListContact()
        {
            return _db.Contacts.ToList();
        }
        public static int GetIdAccordingPhone(string phone) 
        {
            return _db.Contacts.Where(c=>c.PhoneNumber==phone).FirstOrDefault().Id;            
        }
    }
}
