//Objects

const calisan = {
  isim: "barbaros",
  soyisim: "Ciga",
  yas: 30,
  adres: {
    sokak: "bar bukvarı",
    il: "istanbul",
    mahalle: "Beşiktaş",
    ulke: "Turkey",
  },
  yetenekler: ["gitar", "saz", "yanflüt"],
};
console.log(calisan);
console.log(calisan.isim);
console.log(
  `Çalışanımızın ismi ${calisan.isim}, soyadı${calisan.soyisim} ve yaşı ${calisan.yas}`
);
console.log(calisan.yetenekler[2]);
console.log(calisan.adres.mahalle);


//Destruct etmek

const{isim,yas,adres:{il}}=calisan;
console.log(isim,yas,il);
calisan.email="aslihanqgmail";
console.log(calisan);
const rockGrouplari=
[
    {
        id:1,
       name:"Metallica",
       dsc:"Trash Metal",
      concertinTurkey:false,
    

    },
    {
        
        id:2,
        name:"KoRn",
        dsc:"Nu Metal",
        concertinTurkey:true,
        
    
    },
    {
        id:3,
        name:"Disturbed",
        dsc:"Nu Metal",
        concertinTurkey:false,
        
    
    },
    {
        id:4,
        name:"Blind Guardian",
        dsc:"Power Metal",
        concertinTurkey:true,
        
    
    },
    
];
console.log(rockGrouplari[3].name);
//json conver etme metodu
const jsonyapi=JSON.stringify(rockGrouplari);
console.log(jsonyapi);

