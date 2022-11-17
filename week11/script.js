$("document").ready(function () {
  $("body").append("<h1>jQuery Denemesine Hoşgeldiniz.</h1>");
  $("h2:first")
    .css("border", "3px dotted black")
    .css("fontSize", "30px")
    .css("color", "red");
  //first dediğimiz aman birinciyi algılar ve sadece onda uygular.
  //nth-2(child) 2. ye gider ya da nth(1) dediğimiz zaman index numarası gibi davranıp 2. yi algılar.
  //h2:first,h2:last dediğimiz zaman hem 1. hem 3. yü algılar.

  $("#uyari").on("click", alertfunc);
  var user = "aslıkljhan";
  function alertfunc() {
    // window.alert("butona basıldı");
    // swal("Good job!", "You clicked the button!", "success");
    if (user == "aslıhan") {
      swal({
        title: "Success!",
        text: `hoşgeldiniz.${user}`,
        icon: "success",
        button: "Devam et",
      });
    } else {
      swal({
        title: "Wrong User!",
        text: "You clicked the button!",
        icon: "warning",
        button: "Yeniden Dene!",
      });
    }
    $("body")
      .css("backgroundColor", "yellow")
      .css("fontSize", "20px")
      .css("fontweight", "bold")
      .css("border", "3px solid purple");
  }
});
