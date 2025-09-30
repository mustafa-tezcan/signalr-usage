<!DOCTYPE html>
<html lang="tr">
<head>
    <meta charset="UTF-8">
    <title>SignalR Kullanımı Örneği</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            padding: 40px;
            max-width: 800px;
            margin: auto;
            background-color: #f9f9f9;
            color: #333;
        }
        h1 {
            color: #2c3e50;
            border-bottom: 2px solid #2c3e50;
            padding-bottom: 10px;
        }
        h2 {
            color: #34495e;
            margin-top: 30px;
        }
        ul {
            margin-left: 20px;
        }
        li {
            margin-bottom: 8px;
        }
        code {
            background-color: #ecf0f1;
            padding: 2px 4px;
            border-radius: 4px;
        }
        p {
            margin-bottom: 15px;
        }
    </style>
</head>
<body>
    <h1>SignalR Kullanımı Örneği</h1>

    <h2>Projenin Amacı</h2>
    <p>Bu proje, ASP.NET Core SignalR kullanarak gerçek zamanlı mesajlaşma ve grup yönetimi işlevselliği sağlayan bir uygulamadır. Kullanıcılar anlık olarak mesaj gönderip alabilir ve belirli gruplara katılarak sadece o grup içindeki mesajları görebilir. Proje temel olarak bir chat sistemi ve grup yönetimi mekanizmasını göstermektedir.</p>

    <h2>Projenin İçeriği</h2>
    <ul>
        <li><strong>Hubs/</strong>: SignalR hub sınıfları, istemcilerle sunucu arasında gerçek zamanlı iletişimi sağlar.</li>
        <li><strong>Controllers/</strong>: API denetleyicileri, uygulama verilerini yönetir.</li>
        <li><strong>Business/</strong>: Mesaj ve grup yönetimi iş mantığını içerir.</li>
        <li><strong>Interfaces/</strong>: Arayüz tanımları.</li>
        <li><strong>HTML & jQuery</strong>: Basit bir önyüz ve istemci tarafı etkileşimleri.</li>
    </ul>

    <h2>Kullanılan Teknolojiler</h2>
    <ul>
        <li><strong>ASP.NET Core 8.0</strong>: Sunucu tarafı geliştirme ve SignalR entegrasyonu</li>
        <li><strong>SignalR</strong>: Gerçek zamanlı mesajlaşma ve grup yönetimi</li>
        <li><strong>HTML5 & jQuery</strong>: Önyüz ve istemci tarafı etkileşimleri</li>
    </ul>
</body>
</html>
