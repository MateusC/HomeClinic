using HomeClinic.Domain.Entity;

namespace HomeClinic.DAL.Mapping
{
    class EnterpriseMap : AbstractMap<Enterprise>
    {
        public EnterpriseMap()
        {
            Table("SISTEMA_EMPRESA_CADASTRO");

            Id(x => x.Id).Column("ID").Not.Nullable();

            Map(x => x.Name).Column("NOME").Nullable();

            Map(x => x.FancyName).Column("APELIDO").Nullable();

            Map(x => x.Cnpj).Column("CNPJ").Nullable();

            Map(x => x.Adress).Column("LOGRADOURO").Nullable();

            Map(x => x.Neighborhood).Column("BAIRRO").Nullable();

            Map(x => x.PhoneNumberOne).Column("TELEFONE1").Nullable();

            Map(x => x.PhoneNumberTwo).Column("TELEFONE2").Nullable();

            References(x => x.Country).Column("IDMUNICIPIO").Nullable();
        }
    }
}
