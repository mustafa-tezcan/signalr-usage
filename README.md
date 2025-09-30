# 💬 SignalR Kullanımı Örneği

Bu proje, **ASP.NET Core SignalR** kullanarak gerçek zamanlı mesajlaşma ve grup yönetimi işlevselliği sağlayan bir uygulamadır.  
Kullanıcılar anlık olarak mesaj gönderip alabilir ve belirli gruplara katılarak sadece o grup içindeki mesajları görebilir.  

Temel olarak bir **chat sistemi** ve **grup bazlı iletişim mekanizması** sunmaktadır.

---

## 🎯 Projenin İçeriği

- 📡 **Hubs/** → SignalR hub sınıfları, istemcilerle sunucu arasında gerçek zamanlı iletişimi sağlar.  
- 🗂 **Controllers/** → API denetleyicileri, uygulama verilerini yönetir.  
- ⚙️ **Business/** → Mesaj ve grup yönetimi iş mantığını içerir.  
- 🔑 **Interfaces/** → Arayüz tanımları.  
- 🌐 **HTML & jQuery** → Basit bir önyüz ve istemci tarafı etkileşimleri.  

---

## 🧪 Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|-----------|----------|
| **ASP.NET Core 8.0** | Sunucu tarafı geliştirme ve SignalR entegrasyonu |
| **SignalR** | Gerçek zamanlı mesajlaşma ve grup yönetimi |
| **HTML5 & jQuery** | Önyüz ve istemci tarafı etkileşimleri |

---
