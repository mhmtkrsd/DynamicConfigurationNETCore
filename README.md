İlk olarak consulun bilgisayarınızda çalışır halde olması gerekir. 
Bunun için "docker run -d -p 8500:8500 -p 8600:8600/udp --name=my-consul consul agent -server -ui -node=server-1 -bootstrap-expect=1 -client=0.0.0.0" komutunu çalıştırın. 
Tarayıcınızdan http://localhost:8500/ adresine gidin. 
Sol menüden key/value içerisine gidin. 
Gelen ekranda create butonuna tıklayın. 
Key or folder bölümüne "ServiceA/" yazın ve kaydedin. 
Bu sayede ServiceA adında bir klasör oluşturmuş olacaksınız. 
Klasörün içerisine girdikten sonra key bölüme appsettings.json ve appsettings.Development.json adını verdiğiniz iki adet key/value oluşturun. 
Bu keylerin value değerlerini ilk olarak

{ “Name”:“SiteName”, “Type”:“String”, “Value”:“Boyner.com.tr”, “IsActive”:“1", “ApplicationName”:“Service-A” }

şeklinde yazın. 
Bu işlemi appsettings.json dosyasında da appsettings.Development.json dosyasında da yapın. 
Messages Controllerına istek attığınızda console da girdimiz değerleri göreceksiniz. 
Projeyi durdurmadan valuelarını değiştirin. 
Tekrar istek attığınızda console'a yazılan değerlerin değiştiğini göreceksiniz. 
Bu sayede restart edilmeden IConfiguration objemizi güncelleyebiliyoruz.
