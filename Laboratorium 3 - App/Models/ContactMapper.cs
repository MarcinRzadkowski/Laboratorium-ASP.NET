using Data.Entites;
namespace Laboratorium_3___App.Models
{
    public class ContactMapper
    {
        public static ContactEntity toEntity(Contact model)
        {
            return new ContactEntity()
            {
                ContactId = model.Id,
                Name = model.Name,
                Birth = model.Birth,
                Phone = model.Phone,
                Email = model.Email,
            };
        }

        public static Contact fromEntity(ContactEntity entity)
        {
            return new Contact()
            {
                Id = entity.ContactId,
                Name = entity.Name,
                Phone = entity.Phone,
                Email = entity.Email,
                Birth = entity.Birth
            };
        }
    }
}
