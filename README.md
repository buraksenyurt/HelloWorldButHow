# Hello World But How

Bir programlama dilini öğrenmeye başladığımızda genellikle ilk yapılan örnek HelloWorld, hello_world_, helloWorld, hello-world benzeri isimlendirmelerle hazırlanan merhaba uygulamaları olur. Pek çok başlangıç rehberi veya kılavuzu ortam üzerinden ekrana birşey yazdırmakla yetinir. İlk kez programlama deneyimi yaşayanlar için ideal bir senaryo gibi dursa da en azından birkaç yıllık programlama deneyimi olan veya farklı programlama dili/dilleri ile bir şeyler geliştirmiş bireyler için bu tip başlangıçlar tad vermeyebilir. Bu profile uyanlar için bazen karşılaştırmalı senaryolar ortaya koymak ya da birden fazla dil özelliği ile materyalini beraberce gösterebileceğimiz örnek senaryolar üzerinden hareket etmek daha anlamlıdır. Eğer bu bir eğitim serisi olacaksa ileride tekrardan bakılabilecek ya da içeriği kullanılabilecek türden giriş uygulamaları daha yerinde bir seçim olacaktır. 

Bu tip girizgahlarda profilin zaten öğreneceği programlama dili için gerekli ortamları hazırladığı ya da kolayca muhakeme yapıp sorgulayacağı düşünülmelidir. Örneğin yıllarca ABC dili ile geliştirme yapmış bir ekibe XYZ dilini anlatacağımızı düşünelim ya da üniversite öğrencilerine daha önceden gördükleri programlama derslerinden farklı bir tanesini. Kabul ve yönlendirme, kitlenin bazı hazırlıkları kendisinin yapması gerektiği üzerine olmalıdır. Kişisel görüşüm bu gibi durumlarda programlama dilinin birden fazla özelliğinin beraber kullanıldığı, çıktısı tartışılabilir, yeniden düzenlenmeye _(refactor)_ açık _(bu sayede Clean Code teorilerine geçiş kolaylaşır)_ program kodları yazarak ilerlemektir. Hatta anlatılan kitle için araştırma yapmalarını sağlayacak tavsiyeler bırakmak çok yerinde olacak, tek taraflı bir anlatım yerini sürdürülebilir ve katılımcı bir iletişime bırakacaktır. 

İşte bu felsefe ile yola çıkıp mesleki hayatım boyunca sıklıkla kullandığım **C# dilinde Hello World** yazmak istesem nasıl yapardım sorusuna cevap vermeye çalışıyorum. Bu reponun açılma amacı tamamen buna hizmet ediyor. Kişisel görüşme göre bu senaryolar ve uygulama metodolojisi, farklı programlama dilleri için de söz konusu olabilir. Kodlamada kullanılan ifadeler, anahtar kelimeler profile yabancı gelebilir/gelecektir. Ancak bu birazda sürekli kod yazma pratiği ile alakalıdır. Hello World uygulamalarında amaç, dilin genel felsefesini _(burada OOP)_ sağlamış olduğu araçların küçük bir kümesi ile gerçeklenebilir senaryolar üzerinde gösterebilmektir. Bir başka deyişle syntax veya anahtar kelimeler dert edilmesi gereken son şeyler olmalıdır.

- [Giriş](#hello-world-but-how)
  - [Hello World I](#hello-world-i)
    - [Senaryo](#senaryo)
    - [Kullanılan Kavramlar](#kullanılan-kavramlar)
    - [Kazanımlar](#kazanımlar)
    - [Tartışma Soruları](#tartışma-soruları)
  - [Hello World II](#hello-world-ii)
    - [Senaryo](#senaryo-ii)
    - [Kullanılan Kavramlar](#kullanılan-kavramlar-ii)
    - [Kazanımlar](#kazanımlar-ii)
    - [Tartışma Soruları](#tartışma-soruları-ii)
    - [Video Anlatım](#video-anlatım-ii)
  - [Hello World III](#hello-world-iii)
    - [Senaryo](#senaryo-iii)
    - [Kullanılan Kavramlar](#kullanılan-kavramlar-iii)
    - [Kazanımlar](#kazanımlar-iii)
    - [Tartışma Soruları](#tartışma-soruları-iii)
    - [Video Anlatım](#video-anlatım-iii)
  - [Hello World IV](#hello-world-iv)
    - [Senaryo](#senaryo-iv)
    - [Kullanılan Kavramlar](#kullanılan-kavramlar-iv)
    - [Kazanımlar](#kazanımlar-iv)
    - [Tartışma Soruları](#tartışma-soruları-iv)
    - [Video Anlatım](#video-anlatım-iv)
  - [Hello World V](#hello-world-v)
    - [Senaryo](#senaryo-v)
    - [Kullanılan Kavramlar](#kullanılan-kavramlar-v)
    - [Kazanımlar](#kazanımlar-v)
    - [Tartışma Soruları](#tartışma-soruları-v)
    - [Video Anlatım](#video-anlatım-v)

## Hello World I

Bu versiyon daha çok üniversite son sınıf öğrencileri veya yazılım kursiyerleri için kullanılabilir. Bir programlama dili dersini almış ya da uğraşmış olmak veya birkaç yıl programlama dili tecrübesine sahip olmak _(bireysel çalışmalarla da olabilir, staj programlarındaki işlerle de gerçeklenebilir)_ ön gereksinimlerdendir. Senaryoyu işleten kod zorlayıcı olabilir ancak amaç düşünmeye itmek ve sorgulatmaktır.

### Senaryo 

Dönem boyunca verilecek ödevlerin listesi json formatlı bir dosyadan okunarak terminal ekranına yazdırılır.

### Kullanılan Kavramlar

- Json için nesne modellemesi
- Sınıf tanımlamaları ve metot kullanımları
- Override ile davranış değiştirme
- Basit veri türleri kullanımı
- Encapsulation
- Generic liste verisi ve döngü kullanımı

### Kazanımlar

Bu senaryoda ödevler **JSON** bazlı bir dosyada durur. **.Net** çalışma ortamının dışında **JSON** standartlarında tutulan bir veri içeriğinin, nesne yönelimli dil özellikleri barındıran C# ortamında nasıl ele alınacağına bakılır. Amaç dış dünya kavramlarını nesne olarak modellemenin yollarını tartışmaktır. Model nesnesi tanımı bir başlangıçtır. İçeriğinin doldurulması .Net'in yardımcı kütüphaneleri ile gerçekleştirilir. Bu, dilin bazı noktalarda **built-in** gelen paketleri kullanarak işleri nasıl kolaylaştırdığını göstermenin ve **Nuget** ortamını araştırma tavsiyesi olarak vermenin de bir yoludur _(Hatta bir Nuget klonunun yazılması dönem ödevi olarak sunulabilir)_ Bu kavramlar üzerinden geçilirken verinin nasıl ifade edileceği sorusu gündeme gelir ve basit veri tipleri gündeme alınır. Ödevleri benzersizleştirmek için kullanılan **Guid** ekstra bir bonus olarak görülebilir. Kritik noktalardan birisi **Supervisor** sınıfının inşasıdır. Ufak ufak, öğrencilerin bünyesinde sorumlulukların doğru dağıtılması için gerekli motivasyon aktarılmaya çalışılır ancak açık uçlu sorular da ortaya bırakılır. **ToString** metodundan yola çıkılarak ata tür _(super class, super object, base object artık nasıl isimlendirirsek)_ kavramına değinilir ve ortak davranışların değiştirilmesi gündeme taşınır.

### Tartışma Soruları

Bu uygulama sonrasında öğrencilerden bazı sorular beklenir veya bir tartışma başlatılarak aşağıdaki maddeler üzerinde durulur.

- Dosya adı yanlış yazılırsa veya lokasyonu değişirse ne olur?
- Json içeriğindeki bir alan kaldırılırsa ne olur?
- Veri json dosya yerince csv tabanlı bir dosyadan okunmak isterse nasıl bir yönteme gidilir?
- Söz konusu veri kümesi dosyadan okunmak zorunda mıdır? Farklı makinelerden, farklı process'lerden çekilebilir mi? _(İş modellerinin çoğunlukla kapalı devre modeller üzerinde koşmadığı, dağıtık yapıların da var olduğu ve sıklıkla kullanıldığı düşünceleri eşliğinde tartışılabilir)_
- Level, sayısal bir değer yerine daha akılda kalıcı bir şekilde ifade edilebilir mi? _(Enum türü için yönlendirme)_
- Döngü olarak tek kullanım şekli foreach midir? Farklı yollar var mıdır? _(Diğer yolları pratik etmek için ödev verilebilir)_

## Hello World II

Bu versiyon da Hello World I uygulamasındaki profil ve üstü için uygundur.

### Senaryo II

Bu sefer elimizde **CSV** formatında bir kullanıcı listesi bulunuyor. Kullanıcıların ad soyad bilgileri, sisteme giriş adları ve e-posta adresleri yer alıyor. Kullanıcı bilgilerinin satır bazında okunması ve ekrana yazdırılması söz konusu.

### Kullanılan Kavramlar II

- CSV dosya formatının kullanılırlığı _(Halen pek çok büyük mainframe bu tip dosya formatlarında içerik sunmaktadır. Hatta bir Excel çıktısı bile CSV olarak sisteme dahil edilebilir. Hatta segment bazlı dosyalar da tartışılabilir)_
- Dosya satırlarının nesne modellemesi
- class/struct ve record kullanımı _(Başlangıçta class/struct olarak tasarlanan veri modelinin salt okunur bir yapıda kullanılması sebebiyle record veri yapısına geçilir ve böylece üç farklı veri yapısı tanıtılmış olur)_
- Constrcutor ile nesne inşası
- Readonly field/property kullanımı
- Basit döngü kurguları
- Generic liste verisi ve döngü kullanımı

### Kazanımlar II

Bu senaryoda yine çalışma zamanı _(runtime)_ dışındaki bir ortamdan veri çekilmesi ve belleğe alınarak kullanımı planlanmaktadır. **CSV** türü yaygın kullanılan dosya formatlarından birisidir ve şeması belli veri yapılarının anlatılmasından önce bir altyapı sağlayacaktır. Böylece veri odaklı uygulamalarda veriyi saklama yolları, veriler arasındaki ilişkileri kurmak, şemasız veri modelleri, sistemler arası veri transferi ve bu esnada kullanılan protokollerin önemi ilerleyen derslerde tartışmaya açılabilir. **POCO** _(Plain Old CLR Object ya da Dummy Entity)_ olarak tasarlanan **User** veri modeli nihayetinde **record** türü olarak tanımlanmıştır. Böylece **record** veri türünün hangi senaryolarda ele alınacağı üzerine tartışma açılabilir. **IdentityManager** yapısında **constructor** kavramı ele alınırken varsayılan _(default)_ verisyonun ezilmesi ve sonuçları ortaya konur. Her zaman olduğu gibi sorumlulukların doğru dağıtımı vurgulanmaya çalışılır ve **SOLID**'in **Single Responsibility** ilkesi ufaktan düşünce tohumu haline getirilir.

### Tartışma Soruları II

- Struct veya class yerine neden record veri türü kullanıyoruz? _(Bellek üzerindeki açılımları, stack ve heap bazındaki yorumlamaları araştırma konusu olarak tavsiye edilir)_
- Dosya kolonlarına erişirken 0,1,2 gibi rakamlar program kodunu okuyan için anlamlı değildir. Alternatif/ler ne olabilir? _(Enum türüne yönlendirme, mapping kavramları öne çıkarılır)_
- Dosya şema yapısı değişirse ne olur?
- Dosya lokasyonu değişirse ne olur?
- Aynı veri kümesini CSV yerine farklı formatlarda sağlamak istediğimizde program kodu bunu nasıl ele alır?
- IdentityManager isimlendirmesi mantıklı mıdır? _(Özellikle bu sınıfın aslında bir dosyadan kullanıcı listesi okuyup bir koleksiyonda sakladığı düşünülürse)_

## Hello World III

İlk iki senaryoda bahsedilen profil ve üstü bu senaryoda ile de çalışabilir.

### Senaryo III

Bu sefer oyun motorlarının ilerleyen derslerde **Entity Component System**'e evrilebilecek bir senaryosu üzerinde durulur. İki boyutlu bir platformer oyununda oyuncu ve rakibin yönetici bir nesne içerisinde kurgulanması ve sadece başlangıç konumunda set edilen içeriğin ekrana yazdırılması üzerinde durulur.

### Kullanılan Kavramlar III

- Key;Value türevli koleksiyon kullanımı
- Key;Value türlerinde Value olarak liste verisi kullanımı
- Nesne davranışı değiştirme _(ToString override)_
- Ortak bileşenler için türetmeden _(Inheritance)_ tanımlama _(World nesnesindeki dictionary koleksiyonunda önce Object türü kullanılır ama sonra olması gerektiği gibi bir başka türetme değerlendirilir)_
- Object ata türü ve riskleri
- Türetme ve generic kullanımı

### Kazanımlar III

Bu senaryo zor görünse de aslında yapılan bol bol sınıf tasarlamak, bu sınıflara ait koleksiyonlar kullanmaktan ibarettir. Çok ilkel olarak platform oyununda hareket etme, yerleşim, kuvvet ve sağlık/can gibi bileşenler gerçekten de bir **Component** olarak düşünülür. Component'leri birleştirip bunları bir **Entity** olarak ifade etmek ve bu düşünce felsefesini aktarmak çok kritiktir. Böylece oyun sahasındaki bir karakterin esasında kendisi ile ilişkili bileşenleri içeren bir başka nesne olduğu ifade edilir. Başlangıçta her şeyin **Object** türünden geldiği düşünülerek farklı nesnelerin aynı tür koleksiyonda toplanması üzerinde durulur. **Object** türü kullanımının sakıncası ortaya konulduktan sonra türetme ve generic kavramlarından bahsedilir.

### Tartışma Soruları III

- World nesnesinde belli bileşenlere _(Component)_ sahip nesneleri nasıl buluruz? _(Mesela sadece velocity kabiliyeti olanları bulmak gibi. Bu ECS'in System fonksiyonlarını açıklayacak bir tartışmadır)_
- Çok fazla bileşenden oluşan nesne listelerinde aranan belli bir Entity'ye çabuk gitmenin bir yolu olabilir mi? _(Yüzlerce nesnenin olduğu bir senaryoda FPS döngüsünde işleyen fonksiyonlar sıklıkla bir takım Entity'leri bulmak zorunda kalacaktır. Hızlı bir şekilde bunlara erişmenin yolları arama algoritmalarını da gündeme taşıyabilir)_

## Hello World IV

NotImplementedException();

### Senaryo IV

NotImplementedException();

### Kullanılan Kavramlar IV

NotImplementedException();

### Kazanımlar IV

NotImplementedException();

### Tartışma Soruları IV

NotImplementedException();

## Hello World V

NotImplementedException();

### Senaryo V

NotImplementedException();

### Kullanılan Kavramlar V

NotImplementedException();

### Kazanımlar V

NotImplementedException();

### Tartışma Soruları V

NotImplementedException();
