// console.log("s.a");
// window.alert("S.A");
// prompt("yazın");

//yorum satırı
/*yorum satırı ctrlkc,ctrlku ilede yazabilirsiniz*/
/* shift home ile hepsini seçmeye yarar*/
// Örnek yazımızı yazdık
// data tipleri
// undefined,string,boolean,Number,object,null,NaN
// DEĞİŞKEN NASIL TANIMLANIR
//var,let ve const ile tanımlanır.
//const değeri sabitler.
// const pi = 3.14;
// console.log(pi);

// var nextint = prompt("SaYI GİRİNİZ");
// console.log(nextint);
// var mesaj = "Girmiş olduğunuz ifade" + nextint;
// window.alert(`Girilmiş olan sayı ${nextint}`);
// console.log("Girilmiş olan ifade: " + nextint);
// console.log(mesaj);

var name = "Barbaros";
var surname = "Ciga";
var age = 30;
const sabit = 15;

console.log(name, surname, age, sabit);
name = "aslıhan";
surname = "ozkaya";
// sabit=16;
console.log(name, surname, age, sabit);
var name = "kağan";
var surname = "aslan";
// let age = 25;
console.log(name, surname, age, sabit);
var name = "kağan";
var surname = "aslan";
// let age = 23;
console.log(name, surname, age, sabit);
//değişken atamaları yaparken başında kullanmış olduğumuz tip yani
// (var,let,const) arasında belli farklar vardır.const sabit ifadeler için.let ve var arasındaki şuan bildiğimiz fark üst kod bloklarında var
// ile tipi belirtilen bir değişken ataması yapıldıktan sonra alt blocklarda tekrar var ön ekiyle aynı değişlkene yeni bir değer atabiliyorken
//aynı işlem let ile gerçekleşmez.yani örneğin üst kodlarda letx=5; dendikten sonra alt kodlarda let x=10
// diyemezsiniz.bunu yerine tıpkı c# daki gibi x=10;
// // diğerek değeri güncellersiniz.

//değişiken oluşturma yöntemleri
//değişken oluştururken değer atmak
var x = 5;
//değişkeni oluşturup değeri daha sonrada atayabilirsiniz.
var y;
let z;
console.log(x);
console.log(y);
//önceden ram bellekte tanıtımını yapmış olduğumuz y değişkenin alt satırda değer atayabiliyoruz.
y = 25;
z = y;
console.log(x, y, z);
z = 6;
f = "6";
console.log(typeof z, typeof f);
console.log(z == f);
//iki eşitt yazdığımızda number ve string önemsemiyor üç eşit yazdığımzıda number ve stringi önemser
//js case sensitive.büyük küçük harfe duyarlı
let hocaninadi = "Aslıhan";
console.log(hocaninadi); //output alamyız.hata verir

//Değişken oluşturma kurallı.Değişken isminin başında rakam kullanılmaz sonunda ya da içinde kullanılır.
// let 2falan=15;
// let degisken2=15;
//özel ifadelerde de aynı şekilde kullanılmaz.
// yalnızca_kullanılabilir.

// let b.asd=35 kullanılmaz
// let_sayi=35; kullanılır
//örnek bool içine değer atama
// let tenefus20Dakikami=true;
// let isAdmin=false;

const kisiler = ["Ahmet", "Mehmet", "Fikret", 35];
console.log(kisiler);
console.log(typeof kisiler);

document.getElementById("deneme").innerHTML = "<h3> Wissen </h3>";

var a = 10;
let k = 22;
var toplam = 15 + 26;
toplam = a + k;
console.log(a + k);
console.log(toplam);
console.log(a - k);
console.log(a / k);
console.log(a * k);
console.log(a ** 2);
console.log(a % 10);
a++;
console.log(a);
a--;
console.log(a);
const ondalikli = 5.17;
console.log(ondalikli);
//kaçış ifadeleri
let mesaj = 'MERHABA "ASLIHAN" BEN .';
console.log(mesaj);
let mesaj2 = 'MERHABA "ASLIHAN" BEN .';
console.log(mesaj2);
let mesaj3 = 'MERHABA "ASLIHAN" BEN .';
console.log(mesaj3);
let mesaj4 = "MERHABA 'ASLIHAN' BEN .";
console.log(mesaj4);

var stringifade = '<a href="www.google.com"></a>';
console.log(stringifade);

var stringifade2 = '<a href="www.google.com"></a>';
console.log(stringifade2);
//"\t" bir tab kadar boşluk verir.
//"\n" bir satır aşağı iner.
//"\" bunu zaten kullandık

//string concatination--string birleştirme
//1-plus operatör
var adim = "aslihan";
var soyadim = "ozkaya";
var fullname = adim + soyadim;
console.log(fullname);

var mesajim =
  "merhaba" + " " + adim + "benim adim ve soyadim" + soyadim + "memnun oldum";
console.log(mesajim);
let baslangic = "selam";
let final = "ben aslı";
baslangic += final;
console.log(baslangic);
console.log(baslangic.length);
console.log(baslangic[baslangic.length - 1]);
//stringlerdeki imutable meselesi
var yaziliMetin = "aslıahnnnn";
yaziliMetin = "ASLIHAN";
yaziliMetin[2] = "d"; //yazilimetini index numarası ile değiştiremeyiz.
console.log(yaziliMetin);

//arrays
//söz dizimi bildiğimiz şekildedir.

const arabalar = ["BMV", "Mercedes", "Saab"];
console.log(arabalar[1]);
const myArray = [
  ["aslıhan", 25],
  ["selin", 35],
  ["aydın", 45],
  ["mehmet", 55],
];
console.log(myArray);
console.log(myArray[3], [1]);

const myArray3 = [
  [
    ["aslıhan", 25, 37],
    ["selin", 35, 34],
    ["aydın", 45, 57],
    ["mehmet", 55, 65],
  ],
  [
    ["aslıhan", 25, 37],
    ["selin", 35, 34],
    ["aydın", 45, 57],
    ["mehmet", 55, 65],
  ],
];
console.log(myArray3);
console.log(myArray3[1][2][1]); //45 i verir
//array metotları
var dizi = ["muhittin", "sucuk", "elmas", "kalpazan"];
console.log(dizi);
dizi.push("Müzik");
console.log(dizi);
dizi[0] = "fazıl";
console.log(dizi);

let dizi1 = [1, 2, 3, 4];
console.log(dizi1);
dizi1.pop();
console.log(dizi1);
//elemansilme
dizi1.shift();
console.log(dizi1);

let dizi3 = ["Ali Riza", "Ferhunde", "Sevket", "Leyla", "Nejla", "Oğuz"];
//terse çevirme
console.log(dizi3);
dizi3.reverse();
console.log(dizi3);
//diziyi siralama
dizi3.sort();
console.log(dizi3);
//delete komutu inde numarasını sabit tutar sadeceiçinde kayıtlı değeri siler dolayısıyla
//sade o indexe erişim sağlamaya çalışıldığında içerik olarak undefined alırız.bütün diziyi çalıştırırsak o bölgenin boş olduğu gözükür.

delete dizi3[0];
console.log(dizi3);
dizi3[0] = "habes maymunu";
console.log(dizi3);

//array concatination --array birleştirme
var dizi4 = ["muz", "elma"];
var dizi5 = ["kivi", "çilek"];
var dizi6 = ["erik", "ananas"];

const newDizi = dizi4.concat(dizi5);
console.log(newDizi);

//array merge

const newArray = dizi4.concat(dizi5, dizi6);
console.log(newArray);

//splice metodu
const array7 = ["aslı", "ayşe", "fatma", "hayriye", "ümit"];
array7.splice(2, 0, "fırtına", "örümcek"); //2.elemendan sonra ekle diyor ilk parametre ,ikinci parametre kaç tane sileceğimizi gösteriyor.0 yazıyor hiç birşey silmeyeceğiz
console.log(array7);
//istediğimiz indexe gidip oradan itibaren kaç tane eleman silmek istiyorsak
array7.splice(2, 1);
console.log(array7);

//string metodu
var string1 = "aslıhan özkaya";
let string = "   barb.ciga@gmail.com";
let str3 = "klxlcvklv lzxdmlxcm kağan lkdclk lkmflm.";
var num1 = 457;
console.log(string1.toUpperCase()); //büyültür
console.log(string1.toLowerCase()); //küçültür
console.log(num1.toString());
console.log(string1.length);
console.log(string1.slice(3, 6));
console.log(string1.slice(-5));
console.log(array7.toString().replaceAll(",", " "));
console.log(string.trimEnd());
console.log(string.trimStart());
console.log(string.trim()); //sağdan soldan tüm boşlukları temizler.
console.log(str3.split(" "));
console.log(str3.indexOf("kağan"));
console.log(str3.indexOf("a"));
console.log(str3.search("ğan"));
console.log(str3.substring(13, 15));
console.log(str3.substr(13, 15));
console.log(str3.endsWith("."));
console.log(str3.startsWith("."));
console.log(str3.includes("ğa")); //içermek ğa içeriyormu
console.log(str3.repeat(2));
