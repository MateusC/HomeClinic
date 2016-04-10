using HomeClinic.Domain.Entity;

namespace HomeClinic.DAL.Mapping
{
    class UserMap : AbstractMap<User>
    {
        public UserMap()
        {
            Table("SISTEMA_USUARIO");

            Id(x => x.Id).Column("IDUSUARIO").Not.Nullable();

            Map(x => x.Name).Column("NOME").Nullable();

            Map(x => x.Password).Column("SENHA").Nullable();
        }
    }
}
