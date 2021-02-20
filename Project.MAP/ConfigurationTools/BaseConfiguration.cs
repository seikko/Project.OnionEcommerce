using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.MAP.ConfigurationTools
{
    public class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            //builder.Property(x => x.CreatedDate).HasColumnName("Yaratılma Tarihi");//Map katmanında veri tabanı ayarlamarını yapıyoruz.
            //n-n ve 1-1 ilişkilerimiz var ise burada kendimiz tanımlıyoruz......
        }
    }
}
