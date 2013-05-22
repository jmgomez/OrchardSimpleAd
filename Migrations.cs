using System;
using System.Collections.Generic;
using System.Data;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace jmgomez.CustomAds {
    public class Migrations : DataMigrationImpl {
        public int Create() {
            SchemaBuilder.CreateTable("AdRecord", (table) => table
                .ContentPartRecord()
                .Column<string>("Url")
                .Column<bool>("Active"));
            
            ContentDefinitionManager.AlterPartDefinition("AdPart",(part)=>part
                .WithField("Image",cfg=>cfg
                    .OfType("ImageField")
                    .WithDisplayName("Image for ad")
                    .WithSetting("ImageFieldSettings.Required","true")
                    ));

           ContentDefinitionManager.AlterTypeDefinition("Ad",(type)=>type
               .Creatable()
               .WithPart("AdPart")
               .WithPart("CommonPart") 
               .WithPart("TitlePart") 
               );

            return 1;
        }
       

    }
}