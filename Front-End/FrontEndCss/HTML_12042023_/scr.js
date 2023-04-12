//Soru 1 : Değişken tanımlayıp, consoleda yazdırma işlemi.
let name1 = "atakan";
console.log(name1);

//Soru 2 : iki sayının toplamını yazdıran program.

let sayi1 = 5;
let sayi2 = 10;
console.log(sayi1+sayi2);

//Soru 3 : obje oluşturalım name: "Bilge" age: 18 isDeveloper: true / false console a çıktısını verelim

let person = {
    name: "Bilge",
    age: 18,
    isDeveloper: true
  };
      
  console.log(person.name);
  console.log(person['name']);
  console.log(person["name"]);
  console.log(person.age);
  console.log(person.isDeveloper); 

  console.log(person);

  //Soru 4 : 3. Sorudaki person'a ülke bilgisi ekleyelim.
  person.country = "Türkiye";
  console.log(person);

  //Soru 5 : property silelim
  delete person.isDeveloper;
  console.log(person);

  //Soru 6 : Person'ın adını değiştirdik.
  person.name = "Bilge Adam";
  console.log(person);

  //Soru 7: Sıfırıncı ve dördüncü elemanı yazdırdık.
  let objects = ["Bilge", "Adam",18,20, true , false, ];
  console.log(objects);
  console.log(objects[0] + " " + objects[4]);
  
  //Soru9 : Adam'ı Kadın yaptık.
  objects[1] = 'Kadın';
  console.log(objects);
  
  //Soru10 : Dizinin sonuna eleman ekledik.
  objects.push("Gökçehan");
  console.log(objects);
  
  //Soru11 : Başa eleman ekleme
  objects.unshift("Aykut Bey");
  console.log(objects);

  //Soru12 : Son elemanı silme
  objects.pop();
  console.log(objects);

  //Soru13 : İlk elemanı silme
  objects.shift();
  console.log(objects);
  
  //Soru14 : aşağı-yukarı yuvarlama
  let number1 = 9.8;
  console.log(Math.ceil(number1)); //yukarı yuvarlama
  console.log(Math.floor(number1)); //aşağı yuvarlama
  console.log(Math.round(number1)); //en yakına yuvarlama
  
  //Soru15 : TernaryIf 
  let number2 = 11;
  console.log(number2%2==0 ? "Sayi çifttir" : "Sayi tektir");
  
  //Soru16 : SwichCase
  let temp = "0-10 Karma";
  let index = 1;

  switch(index) 
  {
    case 0:
        console.log("Hoşgeldin "+ temp);    
      break;
    case 1:
       console.log("Hoşgeldin "+ temp);
      break;
    case 2:
        console.log("Hoşgeldin "+ temp);
        break;
    case 3:
        console.log("Hoşgeldin "+ temp);
        break;
    default:
        console.log("Siz Kimsiniz?");
  }

  //Soru17 : Dizi 
  let array1 = ["Bilge","Ayşe","Fatma","Ali","Veli"];

  for (let i=0;i<5;i++) 
  {
    console.log([i+1]+ ".İsim = "+array1[i]);
  }

  //Soru18 :
  let age1 = 20;

  while(age1<65)
  {
    console.log("Yaş : " + age1++);    
  }
  console.log("Emekli oldunuz.");
  
  //Soru19 : DOWHİLE
  let age2 = 85;
  do {
  console.log("Emekli oldun yaşın " + age2--)
  }
  while (age2 > 65);
  console.log("Emekli olamadın ")
