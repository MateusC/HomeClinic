using HomeClinic.Domain.Entity;

namespace HomeClinic.DAL.Mapping
{
    class AccountMap : AbstractMap<Account>
    {
        public AccountMap()
        {
            Table("EMPRESA_CONTA");

            Id(x => x.Id).Column("IDCONTA").Not.Nullable();

            Map(x => x.Name).Column("NOME").Nullable();

            Map(x => x.FancyName).Column("APELIDO").Nullable();

            Map(x => x.Cnpj).Column("CNPJ").Nullable();

            Map(x => x.Cpf).Column("CPF").Nullable();

            Map(x => x.Rg).Column("RG").Nullable();

            Map(x => x.Adress).Column("LOGRADOURO").Nullable();

            Map(x => x.Neighborhood).Column("BAIRRO").Nullable();

            Map(x => x.RegisterDate).Column("DATA_CADASTRO").Nullable();

            Map(x => x.PhoneNumberOne).Column("TELEFONE1").Nullable();

            Map(x => x.PhoneNumberTwo).Column("TELEFONE2").Nullable();

            Map(x => x.Observation).Column("OBS").Nullable();

            Map(x => x.Crmv).Column("CRMV").Nullable();

            Map(x => x.AccountKind).Column("TIPO").Nullable();

            References(x => x.Country).Column("IDMUNICIPIO").Nullable();
        }
    }
}
