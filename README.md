# Hello World But How

Bir programlama dilini öğrenmeye başladığımızda genellikle ilk yapılan örnek HelloWorld, hello_world_, helloWorld, hw benzeri isimlendirmelerle hazırlanan merhaba uygulamaları olur. Pek çok başlangıç rehberi veya kılavuzu ortam üzerinden ekrana birşey yazdırmakla yetinir. İlk kez programlama deneyimi yaşayanlar için ideal bir senaryo gibi dursa da en azından birkaç yıllık programlama deneyimi olan veya farklı programlama dili/dilleri ile bir şeyler geliştirmiş bireyler için bu tip başlangıçlar tad vermeyebilir. Bu profile uyanlar için bazen karşılaştırmalı senaryolar ortaya koymak ya da birden fazla dil özelliği ile materyalini beraberce gösterebileceğimiz örnek senaryolar üzerinden hareket etmek daha anlamlı olabilir. Eğer bu bir eğitim serisi olacaksa ileride tekrardan dönülebilecek ya da içeriği kullanılabilecek türden giriş uygulamaları daha yerinde bir seçim olabilir. Bu tip girizgahlarda profilin zaten öğreneceği programlama dili için gerekli ortamları hazırladığı ya da kolayca muhakeme yapıp sorgulayacağı düşünülmelidir. Örneğin yıllarca ABC dili ile geliştirme yapmış bir ekibe XYZ dilini anlatacağımızı düşünelim ya da üniversite öğrencilerine daha önceden gördükleri programlama derslerinden farklı bir tanesini. Bu gibi durumlarda kişisel görüşüm programlama dilinin birden fazla özelliğinin bir arada kullanıldığı, çıktısı değerlendirilebilir/tartışılabilir program kodları yazmak olacaktır. Hatta anlatılan kitle için araştırma yapmalarını gerektirecek parçalar bırakmak çok yerinde olacak, tek taraflı bir anlatım yerini sürdürülebilir ve katılımcı bir iletişime bırakacaktır. İşte bu felsefe ile yola çıkarak mesleki hayatım boyunca sıklıkla kullandığım C# dilinde Hello World yazmak istesem nasıl yapardım sorusuna cevap bulmaya çalışıyorum. Bu reponun açılma amacı tamamen buna hizmet ediyor. Kişisel görüşme göre bu senaryolar ve uygulama metodolojisi, farklı programlama dilleri için de söz konusu olabilir.

- [Giriş](#hello-world-but-how)
  - [Hello World I](#hello-world-i)
    - [Senaryo](#senaryo)
    - [Kullanılan Kavramlar](#kullanılan-kavramlar)
    - [Kazanımlar](#kazanımlar)
    - [Tartışma Soruları](#tartışma-soruları)
    - [Video Anlatım](#video-anlatım)
  - [Hello World II](#hello-world-ii)
  - [Hello World III](#hello-world-iii)
  - [Hello World IV](#hello-world-iv)
  - [Hello World V](#hello-world-v)

## Hello World I

Bu versiyon daha çok üniversite son sınıf öğrencileri veya yazılım kursiyerleri için kullanılabilir. Bir programlama dili dersini almış ya da uğraşmış olmak veya birkaç yıl programlama tecrübesi edinmiş olmak _(bireysel çalışmalarla da olabilir, staj programlarındaki bölümlerde de olabilir)_ ön gereksinimlerdendir. Senaryo işletici kod zorlayıcı olabilir ancak amaç düşünmeye itmek ve sorgulatmaktır.

### Senaryo 

Dönem boyunca verilecek ödevlerin listesi json formatlı bir dosyadan okunarak terminal ekranına yazdırılır.

### Kullanılan Kavramlar

- Json için nesne modellemesi
- Sınıf tanımlamaları ve metot kullanımları
- Override ile davranış değiştirme
- Basit veri türleri kullanımı
- Encapsulation
- Liste verisi ve döngü kullanımı

### Kazanımlar

Bu senaryoda ödevler JSON bazlı bir dosyada durur. .Net çalışma ortamının dışında JSON standartlarında tutulan bir veri içeriğinin, nesne yönelimli dil özellikleri barındıran C# ortamında nasıl ele alınacağına bakılır. Amaç dış dünya kavramlarını nesne olarak modellemenin yollarını tartışmaktır. Model nesnesi tanımı bir başlangıçtır. İçeriğinin doldurulması .Net'in yardımcı kütüphaneleri ile gerçekleştirilir. Bu dilin bazı noktalarda built-in gelen paketleri kullanarak işleri nasıl kolaylaştırdığını göstermenin ve Nuget ortamının araştırma tavsiyesi olarak verilmesinin de bir yoludur. Bu kavramlar üzerinde geçilirken verinin nasıl sembolize edileceği sorusu gündeme gelir ve basit veri tipleri kullanıma alınır. Ödevleri benzersizleştirmek için kullanılan Guid ekstra bir bonus olarak görülebilir. Kritik noktalardan birisi Supervisor sınıfının inşasıdır. Yavaştan öğrencilerin bünyesinde sorumlulukların doğru dağıtılması için gerekli motivasyon aktarılmaya çalışılır ancak açık uçlu sorular bırakılır. ToString metodundan yola çıkılarak ata tür _(super class, super object, base object artık nasıl isimlendirirsek)_ kavramına değinilir ve ortak davranışların değiştirilmesi gündeme taşınır.

### Tartışma Soruları

Bu uygulama sonrasında öğrencilerden bazı sorular beklenir veya bir tartışma başlatılarak aşağıdaki maddeler üzerinde durulur.

- Dosya adı yanlış yazılırsa veya lokasyonu değişirse ne olur?
- Json içeriğindeki bir alan kaldırılırsa ne olur?
- Veri json dosya yerince csv tabanlı bir dosyadan okunmak isterse nasıl bir yönteme gidilir?
- Level, sayısal bir değer yerine daha akılda kalıcı bir isimle ifade edilebilir mi? _(Enum türü için yönlendirme)_
- Döngü için tek kullanım şeklide foreach midir? Farklı yollar var mıdır? _(Diğer yolları pratik etmek için ödev verilebilir)_

### Video Anlatım

Kısmet diyelim :D

## Hello World II

Senaryo :

## Hello World III

Senaryo :

## Hello World IV

Senaryo :

## Hello World V

Senaryo :
