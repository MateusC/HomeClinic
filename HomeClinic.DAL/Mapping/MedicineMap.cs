using HomeClinic.Domain.Entity;

namespace HomeClinic.DAL.Mapping
{
    class MedicineMap : AbstractMap<Medicine>
    {
        public MedicineMap()
        {
            Table("EMPRESA_MEDICAMENTO");

            Id(x => x.Id).Column("IDMEDICAMENTO").Not.Nullable();

            Map(x => x.Name).Column("NOME").Nullable();

            Map(x => x.TechnicalName).Column("NOME_TECNICO").Nullable();

            Map(x => x.Application).Column("APLICACAO").Nullable();

            Map(x => x.Observation).Column("OBS").Nullable();
        }
    }
}
