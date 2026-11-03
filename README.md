# Lab 1 - Nhập môn kiểm thử tự động

## Môi trường
- .NET SDK: 10.0.403
- IDE: VS Code + C# Dev Kit
- NUnit, Selenium.WebDriver 4.x, Google Chrome

## Cách chạy
cd FirstTests
dotnet test --logger "console;verbosity=detailed"

Test mở Chrome, truy cập https://www.selenium.dev/, in tiêu đề trang,
kiểm tra tiêu đề chứa "Selenium", sau đó đóng trình duyệt bằng Quit().

## Phần D - Trải nghiệm dùng AI
- Lỗi gặp phải: Assert.AreEqual
- Prompt đã dùng: Tôi dùng C#, .NET 8, NUnit 4, Selenium 4 trên Windows 11. Khi chạy dotnet test bị lỗi: Assert.AreEqual. Nguyên nhân là gì và sửa thế nào?
- Câu trả lời của AI: Khuyến nghị thay thế Assert.AreEqual thành Assert.That
- Nhận xét: Trả lời rất nhanh và có tính chính xác khá cao, Em dùng Assert.AreEqual dẫn đến error, AI khuyến nghị em dùng Assert.That 

## Ảnh minh chứng
Xem thư mục `screenshots/`.
