﻿// <auto-generated />
using Animal_Crud_Mvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Animal_Crud_Mvc.Migrations
{
    [DbContext(typeof(HayvanContext))]
    [Migration("20230429203708_migV.1.0.1")]
    partial class migV101
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Animal_Crud_Mvc.Models.Hayvan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ResimYolu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hayvanlar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Aciklama = "Aslan, kısa, yuvarlak başlı, kısık boyunlu ve yuvarlak kulaklı, kaslı, derin göğüslü bir kedidir. Kürk rengi açık buffdan (devetüyü rengi) gümüş gri, sarımsı kırmızı ve koyu kahverengiye kadar değişmektedir. Alt kısımların renkleri genellikle daha açıktır.",
                            Ad = "Aslan",
                            ResimYolu = "aslan.png"
                        },
                        new
                        {
                            Id = 2,
                            Aciklama = "Dünyanın en hızlı koşan kara hayvanıdır. İsmi Sanskritçede benekli anlamına gelen \"Çitraka\" sözcüğünden gelir. Aslanlar gibi sürü halinde veya saklanarak avlanmak yerine, yüksek hızının avantajını kullanarak avlanan bir hayvandır. Sıfırdan 108 km/saat hıza sadece 3,1 saniyede erişebilmektedir.",
                            Ad = "Çita",
                            ResimYolu = "cita.png"
                        },
                        new
                        {
                            Id = 3,
                            Aciklama = "Kediler anatomik olarak güçlü, esnek bedenleriyle, hızlı refleksleriyle, keskin, geri çekilebilen pençeleriyle ve küçük avları öldürmeye uyarlanmış dişleriyle diğer kedigillere benzerler. Kediler, insan kulakları için çok zayıf ya da çok yüksek frekanstaki sesleri duyabilirler. Karanlığa yakın ortamlarda görebilirler.",
                            Ad = "Kedi",
                            ResimYolu = "kedi.png"
                        },
                        new
                        {
                            Id = 4,
                            Aciklama = "Köpekler evcil ve vahşi olarak hemen hemen dünyanın birçok yerinde yaşarlar. Keskin koku alma ve işitme kabiliyetleri ile etçil memeleri sınıfına girerler. Sahibine bağlılığı ile de ün salmışlardır. Ömürleri bir çok etkene göre değişmekle birlikte 15 ile 20 yıl arasındadır.",
                            Ad = "Köpek",
                            ResimYolu = "kopek.png"
                        },
                        new
                        {
                            Id = 5,
                            Aciklama = "Köpekbalıkları tek bir tür olmayıp toplamda 465'den fazla türü bulunmaktadır. Denizlerdeki besin zincirinde bulunan yırtıcıların en üst zirvesinde bulunmaktadırlar. Kıkırdakları oldukça esnek ve hafif kemiksi bir dokuya sahiptir. Vücutlarının her iki kısmında da 5-7 solungaç yarığı sayesinde nefes alıp vermektedirler.",
                            Ad = "Köpek Balığı",
                            ResimYolu = "kopek-baligi.png"
                        },
                        new
                        {
                            Id = 6,
                            Aciklama = "Erkek yengeçlerin boyu 9 cm, genişliği, kabuğun iki yanındaki dikenlerle birlikte, 22 cm'dir. Dişiler ise bundan daha küçüktür. Boyları 7.5 cm, genişlikleri, yine aynı şartla, 18 cm'dir. Sırt kabuğunun iki yanında dokuzar adet diken bulunur.",
                            Ad = "Mavi Yengeç",
                            ResimYolu = "mavi-yengec.png"
                        },
                        new
                        {
                            Id = 7,
                            Aciklama = "Maymunların ağaçları salıncak gibi kullanmalarına yardımcı olmak için uzun kolları ve bacakları vardır. Bazı maymunlar kuyruklarını neredeyse bir beşinci kol gibi kullanırlar. Kuyruk bir tür kavrayıcıdır. Çoğu maymun türü ağaçsıldırlar fakat bazı türler ise yerde yaşamaya adapte olmuşlardır.",
                            Ad = "Maymun",
                            ResimYolu = "maymun.png"
                        },
                        new
                        {
                            Id = 8,
                            Aciklama = "Tavşangiller familyasını oluşturan memeli türlerin ortak ismi olan tavşan, bitkisel besinler ile beslenen otçul bir hayvandır. Uzun tüylerden meydana gelen kürk yapısı ve çok hızlı koşmasıyla bilinen tavşanlar, yılda iki kez olacak şekilde tüy değiştirme özelliğine de sahip olan bir canlı türüdür.",
                            Ad = "Tavşan",
                            ResimYolu = "tavsan.png"
                        },
                        new
                        {
                            Id = 9,
                            Aciklama = "Erkeklerinin boyu 4.4 ve 5.5 metre olup 1.5 ton ağırlığındadır. Bugüne kadar kayıt edilmiş en uzun zürafa 5.92 m. olup 2 ton ağırlığındadır. Dilleri boynuzumsu yapıya sahiptir. Dişileri ise 4.0 ve 5.0 metre civarı yüksekliğe sahiptir ve erkeklere göre daha hafiftir.",
                            Ad = "Zürafa",
                            ResimYolu = "zurafa.png"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
