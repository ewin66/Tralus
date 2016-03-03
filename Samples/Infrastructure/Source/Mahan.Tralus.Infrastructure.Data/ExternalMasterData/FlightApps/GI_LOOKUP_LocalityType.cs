namespace Mahan.Tralus.Infrastructure.Data.ExternalMasterData.FlightApps
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GI_LOOKUP_LocalityType
    {
        public long? Code { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        public long? ID_GI_Airline { get; set; }

        public long? ID_SYS_Tenant { get; set; }

        [StringLength(200)]
        public string mod1_Code { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Name_EN { get; set; }

        [StringLength(100)]
        public string Tag { get; set; }
    }
}
