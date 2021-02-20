using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.MAP.ConfigurationTools
{
   public class OrderDetailConfiguration:BaseConfiguration<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);//base'i oldugu gibi bırakıyoruz ki o ozelliklerini de alsın
            builder.Ignore(x => x.ID);//Order detail tablosunun ID'sını ignore edip veritabanına gondermiyoruz.
            builder.HasKey(x => new
            {
                x.OrderID,
                x.ProductID
            });

        }

    }
}
