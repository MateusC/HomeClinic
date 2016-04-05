using HomeClinic.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeClinic.DAL.Mapping
{
    class PetMap : AbstractMap<Pet>
    {
        public PetMap()
        {
            Table("EMPRESA_ANIMAL");

            Id(x => x.Id).Column("IDANIMAL").Not.Nullable();

            Map(x => x.Name).Column("NOME").Nullable();

            Map(x => x.BirthDay).Column("DATA_NASCIMENTO").Nullable();

            Map(x => x.ColorOne).Column("COR1").Nullable();

            Map(x => x.ColorTwo).Column("COR2").Nullable();

            Map(x => x.Pelage).Column("PELAGEM").Nullable();

            Map(x => x.Observation).Column("OBS").Nullable();

            Map(x => x.RegisterDate).Column("DATA_CADASTRO").Nullable();

            References(x => x.Account).Column("IDCONTA").Nullable();

            References(x => x.PetBreed).Column("IDRACA").Nullable();
        }
    }
}
