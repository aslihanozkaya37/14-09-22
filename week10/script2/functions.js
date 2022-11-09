//dönüş değeri olmayan ve parametre almayan fonksiyonlar
function selamlama() {
  window.alert("hoşgel");
}
selamlama();
//dönüş değeri olmayan ve parametre alan
//parametre değerlerini istersek eşittir koyup tipinide sağlamasınıda isteyebiliriz eğer tipini belirtmezsek aşağıdaki işlemleri yinede uygulayacaktır.yeterki içerisine parametre eklemiş olalım
//parametrelere fonksiyon oluşturma esnasında eşittir diyip verdğiğmiz değerler default değerlerdir.yani fonksiyonu çağırdığımızda hiçbir değer vermezsek bile
//parametrelere,yinde çalışır ve içerisindeki default değerler üzerinden fonksiyon içerisindeki işlemler gerçekleşir.

// function sayiGoster(sayi1 = 0, sayi2 = 0) {
//   window.alert(sayi1 + sayi2);
// }
// sayiGoster(5, 2);

// function sayiGoster(sayi1 = 0, sayi2 = 0) {
//   window.alert(sayi1 + sayi2);
// }
// sayiGoster();

var sayilk = parseInt(prompt("Lütfen 1. sayıyı giriniz."));
var sayiki = parseInt(prompt("Lütfen 2. sayıyı giriniz"));

function sayiGoster(x, y) {
  window.alert(x + y);
}
sayiGoster(sayilk, sayiki);
