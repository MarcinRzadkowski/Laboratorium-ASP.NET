using Data;
namespace Laboratorium_3___App.Models
{
    public class EFContactService : IContactService
    {
        private readonly AppDbContext _context;

        public EFContactService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Contact contact)
        {
            _context.Contacts.Add(ContactMapper.toEntity(contact));
            _context.SaveChanges();
        }

        public List<Contact> FindAll()
        {
            return _context.Contacts.Select(e => ContactMapper.fromEntity(e)).ToList();
        }

        public Contact? FindById(int id)
        {
            var entity = _context.Contacts.Find(id);
            if (entity is not null)
            {
                return ContactMapper.fromEntity(entity);
            }
            else
            {
                return null;
            }

        }

        public void DeleteById(int id)
        {
            var entity = _context.Contacts.Find(id);
            if (entity != null)
            {
                _context.Contacts.Remove(entity);
            }
            _context.SaveChanges();
        }

        public void Update(Contact contact)
        {
            _context.Contacts.Update(ContactMapper.toEntity(contact));
            _context.SaveChanges();
        }
    }
}
