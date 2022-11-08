//karar yapıları

console.log(5 == "5");
console.log(5 == "5");
/**/
if (yas > 10) {
  console.log("Yaşınız ondan büyüktür.");
} else {
  console.log("Yaşıınız 10'dan küçüktür.");
}
if (yas >= 10 && yas < 20) {
  console.log("yaşınız 10 dan büyüktür,20'den küçüktür.");
} else if (yas > 20) {
  console.log("Yaşınız 20 den büyüktür.");
} else {
  console.log("yaşınız 10 dan küçüktür.");
}

let age = window.alert(prompt("Yaşınızı giriniz"));
var ehliyet = windows.alert(prompt("Ehliyetiniz varmı").toLowerCase());
if (age < 18) {
  window.alert("yaşınız tutmuyor");
} else if (age >= 18 && ehliyet == evet) {
  windows.alert("araba kullanabilirsiniz.");
} else {
  window.alert("ehliyet almalısınız");
}
