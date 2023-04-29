using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Animal_Crud_Mvc.Migrations
{
    public partial class migV100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hayvanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ResimYolu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hayvanlar", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hayvanlar",
                columns: new[] { "Id", "Aciklama", "Ad", "ResimYolu" },
                values: new object[,]
                {
                    { 1, "Aslan, kısa, yuvarlak başlı, kısık boyunlu ve yuvarlak kulaklı, kaslı, derin göğüslü bir kedidir. Kürk rengi açık buffdan (devetüyü rengi) gümüş gri, sarımsı kırmızı ve koyu kahverengiye kadar değişmektedir. Alt kısımların renkleri genellikle daha açıktır.", "Aslan", "~/pictures/aslan.png" },
                    { 2, "Dünyanın en hızlı koşan kara hayvanıdır. İsmi Sanskritçede benekli anlamına gelen \"Çitraka\" sözcüğünden gelir. Aslanlar gibi sürü halinde veya saklanarak avlanmak yerine, yüksek hızının avantajını kullanarak avlanan bir hayvandır. Sıfırdan 108 km/saat hıza sadece 3,1 saniyede erişebilmektedir.", "Çita", "~/pictures/cita.png" },
                    { 3, "Kediler anatomik olarak güçlü, esnek bedenleriyle, hızlı refleksleriyle, keskin, geri çekilebilen pençeleriyle ve küçük avları öldürmeye uyarlanmış dişleriyle diğer kedigillere benzerler. Kediler, insan kulakları için çok zayıf ya da çok yüksek frekanstaki sesleri duyabilirler. Karanlığa yakın ortamlarda görebilirler.", "Kedi", "~/pictures/kedi.png" },
                    { 4, "Köpekler evcil ve vahşi olarak hemen hemen dünyanın birçok yerinde yaşarlar. Keskin koku alma ve işitme kabiliyetleri ile etçil memeleri sınıfına girerler. Sahibine bağlılığı ile de ün salmışlardır. Ömürleri bir çok etkene göre değişmekle birlikte 15 ile 20 yıl arasındadır.", "Köpek", "~/pictures/kopek.png" },
                    { 5, "Köpekbalıkları tek bir tür olmayıp toplamda 465'den fazla türü bulunmaktadır. Denizlerdeki besin zincirinde bulunan yırtıcıların en üst zirvesinde bulunmaktadırlar. Kıkırdakları oldukça esnek ve hafif kemiksi bir dokuya sahiptir. Vücutlarının her iki kısmında da 5-7 solungaç yarığı sayesinde nefes alıp vermektedirler.", "Köpek Balığı", "~/pictures/kopek-baligi.png" },
                    { 6, "Erkek yengeçlerin boyu 9 cm, genişliği, kabuğun iki yanındaki dikenlerle birlikte, 22 cm'dir. Dişiler ise bundan daha küçüktür. Boyları 7.5 cm, genişlikleri, yine aynı şartla, 18 cm'dir. Sırt kabuğunun iki yanında dokuzar adet diken bulunur.", "Mavi Yengeç", "~/pictures/mavi-yengec.png" },
                    { 7, "Maymunların ağaçları salıncak gibi kullanmalarına yardımcı olmak için uzun kolları ve bacakları vardır. Bazı maymunlar kuyruklarını neredeyse bir beşinci kol gibi kullanırlar. Kuyruk bir tür kavrayıcıdır. Çoğu maymun türü ağaçsıldırlar fakat bazı türler ise yerde yaşamaya adapte olmuşlardır.", "Maymun", "~/pictures/maymun.png" },
                    { 8, "Tavşangiller familyasını oluşturan memeli türlerin ortak ismi olan tavşan, bitkisel besinler ile beslenen otçul bir hayvandır. Uzun tüylerden meydana gelen kürk yapısı ve çok hızlı koşmasıyla bilinen tavşanlar, yılda iki kez olacak şekilde tüy değiştirme özelliğine de sahip olan bir canlı türüdür.", "Tavşan", "~/pictures/tavsan.png" },
                    { 9, "Erkeklerinin boyu 4.4 ve 5.5 metre olup 1.5 ton ağırlığındadır. Bugüne kadar kayıt edilmiş en uzun zürafa 5.92 m. olup 2 ton ağırlığındadır. Dilleri boynuzumsu yapıya sahiptir. Dişileri ise 4.0 ve 5.0 metre civarı yüksekliğe sahiptir ve erkeklere göre daha hafiftir.", "Zürafa", "~/pictures/zurafa.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hayvanlar");
        }
    }
}
