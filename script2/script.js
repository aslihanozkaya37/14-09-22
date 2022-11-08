var name = "Seda";
console.log(name);

var tarih = new Date();
console.log(tarih);

console.log(tarih.getDay());
const gunler = [
  "pazartesi",
  "salı",
  "çarşamba",
  "perşembe",
  "cuma",
  "cumartesi",
  "pazar",
];
console.log(gunler[tarih.getDay() - 1]);
console.log(tarih.getMonth() + 1); //0 ile başladdığı için 11. ayda olduğumuz halde 10 u gösterir o sebepten art1 ekledik.
console.log(tarih.getHours());
console.log(tarih.getFullYear());
console.log(tarih.getMinutes());
console.log(tarih.getSeconds());
console.log(tarih.getTime());

const aylar = [
  "ocak",
  "şubat",
  "mart",
  "nisan",
  "mayıs",
  "haziran",
  "temmuz",
  "ağustos",
  "eylül",
  "ekim",
  "kasım",
  "aralık",
];
console.log(aylar[tarih.getMonth()]);
var d = new Date("2025,10,15");
console.log(d);

var d2 = new Date("September 05,2022 04:00:19");
console.log(d2);

var d3 = new Date(2022, 10, 27, 10, 45, 35);
console.log(d3);

const year = tarih.getFullYear();
const month = (tarih.getMonth() + 1).toString();
const day = tarih.getDate();
const hours = tarih.getHours();
const minutes = tarih.getMinutes();
const saniye = tarih.getSeconds();

var goster = `${day}/${month}/${year}|| ${hours}:${minutes}:${saniye}`;
console.log(goster);

//math methods
var num = 5;
console.log(num.toString());
var num1 = 50.739;
// to fixed komutu ondalıklı kısmı yuvarlar
console.log(num1.toFixed(0));
console.log(num1.toFixed(1));
console.log(num1.toFixed(2));
//to precision ile bir tam sayı kısmıda dahil olarak parametre kadar kısımı gösterir.
var num2 = 30.456;
console.log(num2.toPrecision(3));
console.log(number("10a"));

//math formülü

console.log(Math.floor(2.6));
//round metodu ondalık rakam 5 ten yukarıysa yukarı yuvarlar.aşağıdaysa aşağı yuvarlar
console.log(Math.round(2.6));
//ceil metodu sayıyı yukarı yuvarlar
console.log(Math.ceil(2.6));
//mutlak değer
console.log(Math.abs(-500));

var number = Math.floor(Math.random() * (100 - 20) + 20);
console.log(number);

console.log(5 ** 2);
console.log(Math.pow(5, 2));
console.log(Math.min(5, 100, -6, 55));
