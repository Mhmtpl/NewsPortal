# Turkmedya Haber Uygulaması

Bu proje, .NET Core 7 platformunda geliştirilen bir haber uygulamasıdır. Turkmedya'nın sunduğu haber verilerini alarak, kullanıcılara belirli kategorilerdeki haberleri ve detaylarını gösterir. Ayrıca sayfalama özelliği ve filtreleme seçenekleri sunar.

## Özellikler

- **Ana Sayfa**: Turkmedya'nın anasayfa.json dosyasından alınan veriler sayfalı bir şekilde gösterilir.
- **Haber Detayları**: Haber detayları, detay.json dosyasından alınır ve kullanıcıya sunulur.
- **Filtreleme**: Kategori ve anahtar kelimeye göre haberleri filtreleme imkanı sağlar.
- **Sayfalama**: Haberler sayfalara ayrılır ve kullanıcılar sayfalar arasında gezinebilir.

## Proje Yapısı

- `HomeController`: Anasayfa için haberleri alır, filtreler ve sayfalara böler.
- `DetailController`: Haber detaylarını gösterir.
- `INewsService` ve `NewsService`: Turkmedya API'larından veri alır.

## Nasıl Kullanılır?

1. Proje klonlanır veya indirilir.
2. Visual Studio ile projenin çalıştırılması sağlanır.
3. Tarayıcı üzerinden projenin URL'sine gidilir.
4. Anasayfada haberler listelenir, detaylara gitmek için haberlere tıklanır.
5. Kategori veya anahtar kelime filtrelemesi kullanılarak haberler sınırlandırılabilir.

## Gereksinimler

- .NET Core 7 SDK
- Visual Studio 202X

