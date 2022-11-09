// ///for döngüsü

// for (let index = 0; index < 5; index++) {
//   console.log(index);
// }
// // for (let başlatıcı değer=değer; koşul;işlem)
// // {kod blokları işlem vs}

// var metin = prompt("bir metin giriniz");
// let sayi = parseInt(prompt("bir sayı giriniz."));
// for (let index = 0; index < sayi; index++) {
//   console.log({ metin });
// }
// var arr = [];
// for (let index = 0; index < 100; index++) {
//   if (index % 3 == 0) {
//     arr.push(index);
//   }
// }
// console.log(arr);
// windows.alert(arr);

// let kat = prompt("Bir sayi giriniz");
// for (let i = 0; i < 100; i++) {
//   if ((i % 2 == 0, i++)) console.log(i);
//   if (index % 5 == 0) {
//     console.log(bom);
//   }
// }

// //while-do while

// let i = 0;
// while (i < 10) {
//   console.log(i);
//   i++;
// }
// while (true) {
//   var x = prompt("Lütfen bir sayı giriniz.");
//   if (x < 10) {
//     window.alert("Sayı 10'dan küçük");
//     var cikis = prompt("çıkmak istiyormusunuz").toLowerCase();
//     if (cikis == "evet") {
//       break;
//     } else {
//       window.alert("Sayı 10'dan büyük veya eşit");
//       var cikis = prompt("çıkmak istiyormusunuz").toLowerCase();
//       if (cikis == "evet") {
//         break;
//       }
//     }
//   }
// }
// do {
//   console.log(i);
// } while (i < 10);

const işlemler = [
  {
    id: 1,
    işlem: "Uyan",
    yapildimi: true,
  },

  {
    id: 2,
    işlem: "Kahvaltı yap",
    yapildimi: true,
  },

  {
    id: 3,
    işlem: "Derse gir",
    yapildimi: true,
  },

  {
    id: 4,
    işlem: "Öğle Yemeği ye",
    yapildimi: false,
  },
];

//iterasyonel bir for kullanımı
for (let x of işlemler) {
  console.log(x);
}

for (let x of işlemler) {
  console.log(x.yapildimi);
}

//foreach
/*foreach döngüsü kullanılarak fonk döngü işlemleri yapma imkanınız bulunmaktadır.burada dikkat etmeniz gereken konu functiona parametre olarak girdiğimiz 
hayali değeri function scope'u içerisinde geri çağırmaktadır(callback).bu işleme call back denir.ve böylece döngü döndüğü sürece function çalışır. */

işlemler.forEach(function (mahmut) {
  console.log(mahmut.işlem);
});

//map
//map işlemi tıpkı foreach gibi döngüsel işlemleri fonksiyonel olarak

const islemlerIslem = işlemler.map(function (todo) {
  return todo.işlem;
});
console.log(islemlerIslem);

//filter
const todoList = işlemler.filter(function (todo) {
  return todo.yapildimi === true;
});
console.log(todoList);

//filter işlemi belirttiğimiz seçenekleere göre ilgili datdan istediğimiz özelliklere göre yeni bir array döndürür.

const todoListe = işlemler
  .filter(function (todo) {
    return todo.yapildimi === true;
  })
  .map(function (yapilacak) {
    return yapilacak.id;
  });

console.log(todoListe);
