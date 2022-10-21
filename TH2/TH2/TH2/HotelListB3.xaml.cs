using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TH2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class HotelListB3 : ContentPage
    {
        private List<Hotel> dsKS;

        public HotelListB3(City city)
        {
            dsKS = new List<Hotel>();
            List<Hotel> dsKSTemp = new List<Hotel>();

            dsKS.Add(new Hotel
            {
                Name = "Orchids Saigon Hotel",
                CityID = 1,
                ImgSrc = "anh1.jpg",
                Address = "192 Pasteur Street, Ward 6, District 3, Quận 3, TP. Hồ Chí Minh, Việt Nam ",
                Price = "2,800,000",
                Detail = @"Tọa lạc tại Thành phố Hồ Chí Minh, cách Bảo tàng Chứng tích Chiến tranh 500 m, Orchids Saigon Hotel cung cấp chỗ nghỉ với nhà hàng, chỗ đỗ xe riêng miễn phí, trung tâm thể dục và quán bar. Tọa lạc tại một vị trí tuyệt đẹp ở Quận 3, khách sạn này có sảnh khách chung cũng như hồ bơi trong nhà. Chỗ nghỉ cung cấp dịch vụ lễ tân 24 giờ, dịch vụ đưa đón sân bay, dịch vụ phòng và WiFi miễn phí.

Phòng nghỉ tại Orchids Saigon Hotel có máy điều hòa,
                bàn làm việc,
                ấm đun nước,
                minibar,
                két an toàn,
                TV màn hình phẳng và phòng tắm riêng với vòi sen.Các phòng được trang bị ga trải giường và khăn tắm.

Khách lưu trú tại chỗ nghỉ có thể thưởng thức bữa sáng buffet hoặc bữa sáng à la carte.

Orchids Saigon Hotel có sân hiên tắm nắng."
            });


            dsKS.Add(new Hotel
            {
                Name = "Valentine Hotel Saigon - Bùi Viện Street",
                CityID = 1,
                ImgSrc = "anh2.jpg",
                Address = "27-29 Bui Vien, Quận 1, TP. Hồ Chí Minh, Việt Nam",
                Price = "110,000",
                Detail = @"Valentine Hotel Saigon- Bùi Viện Street tọa lạc tại vị trí trung tâm ở quận 1, thành phố Hồ Chí Minh. Khách sạn cách chợ Bến Thành chưa đến 8 phút đi bộ. Các phòng hiện đại có WiFi miễn phí.

Cách bến xe du lịch vài bước chân, Valentine Hotel Saigon- Bùi Viện Street cách 2 phút lái xe ngắn từ trung tâm thành phố Hồ Chí Minh và Nhà hát Thành phố. Sân bay quốc tế Tân Sơn Nhất cách đó 30 phút lái xe.

Được trang bị nội thất bằng gỗ, tất cả các phòng đều có máy điều hòa, TV truyền hình cáp màn hình phẳng và phòng tắm riêng với vòi sen cùng đồ vệ sinh cá nhân miễn phí. Máy sấy tóc và 2 chai nước miễn phí được cung cấp hàng ngày.

Valentine Hotel Saigon- Bùi Viện Street cung cấp dịch vụ đưa đón sân bay có tính phí và bàn đặt vé với thông tin tour du lịch. Du khách có thể kiểm tra email tại trung tâm dịch vụ doanh nhân. Dịch vụ photocopy và fax được cung cấp miễn phí tại đây."
            });


            dsKS.Add(new Hotel
            {
                Name = "La Vela Saigon Hotel",
                CityID = 1,
                ImgSrc = "anh3.jpg",
                Address = "280 Nam Ky Khoi Nghia, Ward 8, District 3, Quận 3, TP. Hồ Chí Minh, Việt Nam ",
                Price = "2,340,000",
                Detail = @"Nằm ở Thành phố Hồ Chí Minh, cách Chợ Tân Định 700 m, La Vela Saigon Hotel cung cấp chỗ nghỉ với nhà hàng, chỗ đỗ xe riêng miễn phí, hồ bơi ngoài trời và trung tâm thể dục. Mỗi chỗ nghỉ tại khách sạn 5 sao này đều có tầm nhìn ra quang cảnh thành phố và du khách có thể thư giãn ở quầy bar cũng như sân hiên. Nơi đây cung cấp dịch vụ lễ tân 24 giờ, dịch vụ đưa đón, dịch vụ phòng và WiFi miễn phí trong toàn bộ khuôn viên.

Mỗi phòng nghỉ tại khách sạn đều được bố trí máy điều hòa, khu vực ghế ngồi, TV truyền hình vệ tinh màn hình phẳng, két an toàn và phòng tắm riêng với vòi xịt/chậu rửa vệ sinh, áo choàng tắm cùng dép. Các phòng của La Vela Saigon Hotel được trang bị ấm đun nước, ga trải giường và khăn tắm. Một số phòng còn có khu vực bếp ăn với tủ lạnh.

Khách lưu trú tại chỗ nghỉ có thể thưởng thức bữa sáng buffet hoặc bữa sáng à la carte.

Bảo tàng Chứng tích Chiến tranh nằm trong bán kính 1,6 km từ La Vela Saigon Hotel trong khi Dinh Thống Nhất cách đó 1,9 km. Sân bay gần nhất là sân bay quốc tế Tân Sơn Nhất, cách khách sạn 10 km."
            });



            dsKS.Add(new Hotel
            {
                Name = "City View Hotel & Spa",
                CityID = 1,
                ImgSrc = "anh4.jpg",
                Address = "15 Bui Thi Xuan Street, Ben Thanh Ward, District 1, Quận 1, TP. Hồ Chí Minh, Việt Nam",
                Price = "455,000",
                Detail = @"Cách Chợ Bến Thành khoảng 10 phút đi bộ, City View Hotel & Spa cung cấp các phòng giá cả phải chăng với Wi-Fi miễn phí. Khách sạn nằm ngay đối diện công viên Tao Đàn và cách Du thuyền đêm trên Sông Sài Gòn 15 phút đi bộ.

Các phòng gắn điều hòa đi kèm với truyền hình cáp màn hình phẳng 32 inch và tủ lạnh mini. Phòng tắm riêng được trang bị tiện nghi vòi sen và máy sấy tóc.

Khách có thể sắp xếp các chuyến đi trong ngày đến Đồng bằng Sông Cửu Long hoặc Địa đạo Củ Chi tại bàn đặt tour. Khách sạn cũng cung cấp dịch vụ cho thuê xe hơi và thu đổi ngoại tệ.

Nhà hàng và quầy bar của khách sạn phục vụ các món ăn địa phương và cà phê Việt Nam. Xung quanh khách sạn cũng có những quán ăn địa phương và cửa hàng bán thức ăn nhanh.

Đây là khu vực ở TP. Hồ Chí Minh mà khách yêu thích, theo các đánh giá độc lập."
            });


            dsKS.Add(new Hotel
            {
                Name = "Hanoi Prime Center Hotel",
                CityID = 2,
                ImgSrc = "anh5.jpg",
                Address = "36 Hang Huong, Quận Hoàn Kiếm, Hà Nội, Việt Nam",
                Price = "365,000",
                Detail = @"Hanoi Prime Centre Hotel cung cấp phòng nghỉ có ban công riêng ở trung tâm thành phố Hà Nội. Trong số các tiện nghi của chỗ nghỉ này có nhà hàng, lễ tân 24 giờ, dịch vụ phòng và WiFi miễn phí. Chỗ nghỉ có thể bố trí chỗ đỗ xe riêng cho khách với một khoản phụ phí.

Phòng nghỉ tại Hanoi Prime Center Hotel được trang bị bàn làm việc, máy điều hòa, TV màn hình phẳng và phòng tắm riêng với vòi sen cùng áo choàng tắm. Một số phòng có sân trong. Tất cả các phòng đều đi kèm ga trải giường và khăn tắm.

Các điểm tham quan nổi tiếng gần Hanoi Prime Center Hotel bao gồm Ô Quan Chưởng, Nhà hát múa rối nước Thăng Long và Hồ Hoàn Kiếm. Sân bay gần nhất là sân bay quốc tế Nội Bài, nằm trong bán kính 25 km từ khách sạn, và chỗ nghỉ cung cấp dịch vụ đưa đón sân bay với một khoản phụ phí."
            });


            dsKS.Add(new Hotel
            {
                Name = "22Land Residence Hotel & Spa",
                CityID = 2,
                ImgSrc = "anh6.jpg",
                Address = "02 Nguyen Dinh Hoan, Cau Giay, Hà Nội, Việt Nam",
                Price = "755,000",
                Detail = @"Tọa lạc tại thành phố Hà Nội, 22Land Residence Hotel & Spa có nhà hàng, xe đạp cho khách sử dụng miễn phí, hồ bơi ngoài trời và trung tâm thể dục. Khách sạn 4 sao này có WiFi miễn phí, quán bar và sảnh khách chung. Chỗ nghỉ cung cấp dịch vụ lễ tân 24 giờ, dịch vụ phòng và dịch vụ thu đổi ngoại tệ cho khách.

Phòng nghỉ gắn máy điều hòa tại 22Land Residence Hotel & Spa có tủ để quần áo, ấm đun nước, minibar, két an toàn, TV màn hình phẳng và phòng tắm riêng với vòi sen. Mỗi phòng đều được trang bị ga trải giường và khăn tắm.

Khách lưu trú tại chỗ nghỉ có thể thưởng thức bữa sáng kiểu lục địa.

22Land Residence Hotel & Spa cung cấp chỗ nghỉ 4 sao với phòng xông hơi khô và sân hiên tắm nắng.

Khách sạn nằm cách Bảo tàng Dân tộc học Việt Nam 1,5 km và trung tâm thương mại Vincom Center Nguyễn Chí Thanh 3,5 km."
            });


            dsKS.Add(new Hotel
            {
                Name = "Beryl Palace Hotel and Spa",
                CityID = 2,
                ImgSrc = "anh7.jpg",
                Address = "173 Hang Bong Street, Quận Hoàn Kiếm, Hà Nội, Việt Nam",
                Price = "943,000",
                Detail = @"Lối trang trí kiểu cổ điển của Pháp và kiến trúc Châu Âu là nét đặc trưng của Beryl Palace Hotel and Spa, một chỗ nghỉ boutique nằm trên Phố Cổ Hàng Bông nhộn nhịp. Chỉ nằm cách Nhà Hát Lớn Hà Nội nổi tiếng 15 phút đi bộ, chỗ nghỉ này cung cấp các liệu pháp mát-xa thư giãn và WiFi miễn phí.

Phòng nghỉ lắp máy điều hòa trang nhã tại đây được trang bị TV màn hình phẳng 32 inch, minibar và két an toàn cá nhân. Một số phòng có tầm nhìn ra quang cảnh thành phố qua cửa sổ vách kính lớn. Các phòng tắm riêng đi kèm vòi sen, bồn tắm hoặc bồn tắm spa.

Beryl Palace Hotel and Spa nằm cách Hồ Hoàn Kiếm, Đền Ngọc Sơn và Chợ Đồng Xuân 10 phút đi bộ ngắn. Ga Hà Nội nằm trong bán kính 10 phút lái xe từ chỗ nghỉ này. Sân bay quốc tế Nội Bài cách đó 45 phút lái xe.

Bàn đặt tour có thể giúp khách thu xếp dịch vụ cho thuê xe đạp, các chuyến đi trong ngày và dịch vụ đưa đón sân bay. Khách sạn cũng có trung tâm dịch vụ doanh nhân, dịch vụ giặt là và lễ tân 24 giờ.

Nhà hàng Beryl phục vụ bữa sáng tự chọn hàng ngày cũng như các món ăn à la carte kiểu phương Tây và Châu Á. Quý khách có thể thưởng thức đồ uống tại quầy bar."
            });


            dsKS.Add(new Hotel
            {
                Name = "Le Beryl Hanoi Hotel",
                CityID = 2,
                ImgSrc = "anh8.jpg",
                Address = "212a Hàng Bông, Quận Hoàn Kiếm, Hà Nội, Việt Nam",
                Price = "900,000",
                Detail = @"Tọa lạc tại thành phố Hà Nội, cách Bảo tàng Mỹ thuật Việt Nam 800 m, Le Beryl Hanoi Hotel có sân hiên, phòng nghỉ không gây dị ứng và WiFi miễn phí. Khách sạn 3 sao này có dịch vụ tiền sảnh, bàn đặt tour, lễ tân 24 giờ, máy ATM và dịch vụ thu đổi ngoại tệ cho khách.

Phòng nghỉ tại khách sạn được bố trí máy điều hòa, khu vực ghế ngồi, TV truyền hình vệ tinh màn hình phẳng, két an toàn và phòng tắm riêng với vòi xịt/chậu rửa vệ sinh, dép cùng máy sấy tóc. Mỗi phòng đều được trang bị bàn làm việc và ấm đun nước.

Le Beryl Hanoi Hotel phục vụ bữa sáng buffet hoặc bữa sáng kiểu Anh/Ailen.

Khu vực này nổi tiếng với hoạt động đi xe đạp và du khách cũng có thể thuê xe hơi tại chỗ nghỉ.

Các điểm tham quan nổi tiếng gần Le Beryl Hanoi Hotel gồm có Văn Miếu - Quốc Tử Giám, Nhà Thờ Lớn và Lăng Chủ tịch Hồ Chí Minh. Sân bay gần nhất là sân bay quốc tế Nội Bài, nằm trong bán kính 25 km từ khách sạn, và chỗ nghỉ cung cấp dịch vụ đưa đón sân bay với một khoản phụ phí."
            });


            dsKS.Add(new Hotel
            {
                Name = "Sapphire Boutique Hotel Da Nang",
                CityID = 3,
                ImgSrc = "anh9.jpg",
                Address = "19 Le Binh Street, An Hai Bac Ward, Son Tra District, Đà Nẵng, Việt Nam",
                Price = "222,000",
                Detail = @"Tọa lạc tại thành phố Đà Nẵng, cách Bãi biển Mỹ Khê 600 m, Sapphire Boutique Hotel Da Nang cung cấp chỗ nghỉ với hồ bơi ngoài trời, chỗ đỗ xe riêng miễn phí, sảnh khách chung và khu vườn. Chỗ nghỉ này có các phòng gia đình và sân hiên. Nơi đây cung cấp dịch vụ lễ tân 24 giờ, dịch vụ phòng và dịch vụ thu đổi ngoại tệ cho khách.

Phòng nghỉ được trang bị máy điều hòa, TV truyền hình vệ tinh màn hình phẳng, tủ lạnh, ấm đun nước, vòi xịt/chậu rửa vệ sinh, dép đi trong phòng và bàn làm việc. Các phòng tại Sapphire Boutique Hotel Da Nang có phòng tắm riêng, tủ để quần áo, ga trải giường và khăn tắm. Một số phòng được bố trí két an toàn.

Cầu Sông Hàn nằm cách chỗ nghỉ 2,2 km trong khi Cầu khóa Tình yêu cách đó 2,7 km. Sân bay gần nhất là sân bay quốc tế Đà Nẵng, nằm trong bán kính 7 km từ Sapphire Boutique Hotel Da Nang, và chỗ nghỉ cung cấp dịch vụ đưa đón sân bay với một khoản phụ phí."
            });


            dsKS.Add(new Hotel
            {
                Name = "Menora Premium Da Nang - Sea Corner Boutique",
                CityID = 3,
                ImgSrc = "anh10.jpg",
                Address = "196 Tran Bach Dang Street, My An Ward, Ngu Hanh Son District, Đà Nẵng, Việt Nam",
                Price = "269,000",
                Detail = @"Tọa lạc tại thành phố Đà Nẵng, cách Bãi biển Mỹ Khê 300 m, Menora Premium Da Nang - Sea Corner Boutique cung cấp chỗ nghỉ bên bờ biển cùng nhiều tiện nghi như hồ bơi ngoài trời và sân hiên. Trong số các tiện nghi của chỗ nghỉ này có nhà hàng, lễ tân 24 giờ, dịch vụ phòng và WiFi miễn phí trong toàn bộ khuôn viên. Khách sạn cung cấp các phòng gia đình.

Phòng nghỉ tại Menora Premium Da Nang - Sea Corner Boutique có máy điều hòa, bàn làm việc, ấm đun nước, tủ lạnh, minibar, két an toàn, TV màn hình phẳng và phòng tắm riêng với vòi xịt/chậu rửa vệ sinh. Mỗi phòng đều được trang bị ga trải giường và khăn tắm.

Chỗ nghỉ phục vụ bữa sáng kiểu lục địa hoặc bữa sáng buffet.

Đi xe đạp là hoạt động được ưa chuộng trong khu vực và du khách cũng có thể thuê xe đạp/xe hơi tại Menora Premium Da Nang - Sea Corner Boutique.

Khách sạn nằm cách Bãi biển Bắc Mỹ An chưa đầy 1 km và Cầu khóa Tình yêu 3 km. Sân bay gần nhất là sân bay quốc tế Đà Nẵng, nằm trong bán kính 6 km từ Menora Premium Da Nang - Sea Corner Boutique, và chỗ nghỉ cung cấp dịch vụ đưa đón sân bay với một khoản phụ phí."
            });


            dsKS.Add(new Hotel
            {
                Name = "Golden Rose Hotel",
                CityID = 3,
                ImgSrc = "anh11.jpg",
                Address = "56 Loseby Phường An Hải Bắc, Quận Sơn Trà, Đà Nẵng, Việt Nam ",
                Price = "341,000",
                Detail = @"Tọa lạc tại thành phố Đà Nẵng, cách Bãi biển Mỹ Khê 500 m, Golden Rose Hotel cung cấp chỗ nghỉ với nhà hàng, chỗ đỗ xe riêng miễn phí và sảnh khách chung. Khách sạn 3 sao này có dịch vụ tiền sảnh và bàn đặt tour. Chỗ nghỉ cung cấp dịch vụ lễ tân 24 giờ, dịch vụ đưa đón sân bay, dịch vụ phòng và WiFi miễn phí.

Tất cả phòng nghỉ tại Golden Rose Hotel được bố trí máy điều hòa, khu vực ghế ngồi, TV truyền hình vệ tinh màn hình phẳng, két an toàn, ấm đun nước và phòng tắm riêng đi kèm vòi sen, áo choàng tắm cùng dép. Một số phòng nhìn ra khu vườn. Mỗi phòng đều được trang bị ga trải giường và khăn tắm.

Golden Rose Hotel nằm cách Cầu Sông Hàn 2,1 km và Trung tâm thương mại Indochina Riverside 2,7 km. Sân bay gần nhất là sân bay quốc tế Đà Nẵng, nằm trong bán kính 7 km từ khách sạn."
            });


            dsKS.Add(new Hotel
            {
                Name = "Cherry Hotel & Apartment Da Nang - Phoenix 2 Hotel",
                CityID = 3,
                ImgSrc = "anh12.jpg",
                Address = "41-42 Do Bi Street, Đà Nẵng, Việt Nam",
                Price = "329,000",
                Detail = @"Nằm ở thành phố Đà Nẵng, Cherry Hotel & Apartment Da Nang - Phoenix 2 Hotel có nhà hàng, hồ bơi ngoài trời, quầy bar và sảnh khách chung. Trong số các tiện nghi của chỗ nghỉ này có dịch vụ phòng, máy ATM và WiFi miễn phí trong toàn bộ khuôn viên. Chỗ nghỉ cung cấp dịch vụ lễ tân 24 giờ, bếp chung và dịch vụ thu đổi ngoại tệ cho khách.

Phòng nghỉ tại khách sạn có máy điều hòa, bàn làm việc, ấm đun nước, tủ lạnh, minibar, két an toàn, TV màn hình phẳng và phòng tắm riêng với vòi xịt/chậu rửa vệ sinh. Một số phòng được bố trí khu vực bếp nấu ăn. Tại Cherry Hotel & Apartment Da Nang - Phoenix 2 Hotel, mỗi phòng đều được trang bị ga trải giường và khăn tắm.

Chỗ nghỉ có sân hiên.

Cherry Hotel & Apartment Da Nang - Phoenix 2 Hotel nằm cách Bãi biển Mỹ Khê 600 m và Bãi biển Bắc Mỹ An 1,2 km. Sân bay gần nhất là sân bay quốc tế Đà Nẵng, nằm trong bán kính 5 km từ khách sạn, và chỗ nghỉ cung cấp dịch vụ đưa đón sân bay với một khoản phụ phí."
            });


            dsKS.Add(new Hotel
            {
                Name = "Bazan Hotel Dalat",
                CityID = 4,
                ImgSrc = "anh13.jpg",
                Address = "36 To Hien Thanh , Đà Lạt, Việt Nam",
                Price = "388,000",
                Detail = @"Tọa lạc tại thành phố Đà Lạt, cách Công viên Yersin 1,6 km, Bazan Hotel Dalat có chỗ nghỉ với quầy bar, chỗ đỗ xe riêng miễn phí, sảnh khách chung và khu vườn. Khách sạn 3 sao này cung cấp dịch vụ phòng và dịch vụ tiền sảnh. Chỗ nghỉ có lễ tân 24 giờ, dịch vụ đưa đón sân bay, bếp chung và WiFi miễn phí trong toàn bộ khuôn viên.

Phòng nghỉ tại khách sạn được trang bị TV màn hình phẳng, phòng tắm riêng, dép và ga trải giường. Một số phòng có tầm nhìn ra quang cảnh núi non.

Hồ Xuân Hương và Quảng trường Lâm Viên đều nằm cách Bazan Hotel Dalat 1,8 km. Sân bay gần nhất là sân bay Liên Khương, nằm trong bán kính 27 km từ chỗ nghỉ."
            });


            dsKS.Add(new Hotel
            {
                Name = "Raon Dalat",
                CityID = 4,
                ImgSrc = "anh14.jpg",
                Address = "46 Tran Khanh Du, Ward 8, Đà Lạt, Việt Nam",
                Price = "130,000",
                Detail = @"Tọa lạc tại thành phố Đà Lạt, cách CLB chơi golf Dalat Palace 1,9 km, Raon Dalat có chỗ nghỉ với sảnh khách chung, chỗ đỗ xe riêng miễn phí, khu vườn và sân hiên. Khách sạn 3 sao này cung cấp dịch vụ phòng và dịch vụ tiền sảnh. Chỗ nghỉ cung cấp dịch vụ lễ tân 24 giờ, dịch vụ đưa đón sân bay, bếp chung và WiFi miễn phí trong toàn bộ khuôn viên.

Phòng nghỉ tại Raon Dalat được bố trí bàn làm việc và phòng tắm riêng với vòi xịt/chậu rửa vệ sinh cùng dép. Một số phòng còn có khu vực ghế ngồi. Các phòng được trang bị máy sấy tóc, ga trải giường và sử dụng phòng tắm chung.

Khu vực này nổi tiếng với hoạt động đi bộ đường dài và đi xe đạp trong khi du khách có thể thuê xe hơi tại chỗ nghỉ.

Raon Dalat nằm cách Vườn hoa Đà Lạt 2,5 km và Hồ Xuân Hương 4,2 km. Sân bay gần nhất là sân bay Liên Khương, cách khách sạn 32 km."
            });


            dsKS.Add(new Hotel
            {
                Name = "TTR Skyview Hotel",
                CityID = 4,
                ImgSrc = "anh15.jpg",
                Address = "50 Phan Nhu Thach, Đà Lạt, Việt Nam",
                Price = "373,000",
                Detail = @"Tọa lạc tại thành phố Đà Lạt, cách Quảng trường Lâm Viên 1,8 km, TTR Skyview Hotel có dịch vụ nhận phòng/trả phòng cấp tốc, phòng nghỉ không gây dị ứng, nhà hàng, WiFi miễn phí trong toàn bộ khuôn viên và sảnh khách chung. Khách sạn 3 sao này có dịch vụ tiền sảnh và bàn đặt tour. Chỗ nghỉ cung cấp dịch vụ lễ tân 24 giờ, dịch vụ phòng và dịch vụ thu đổi ngoại tệ cho khách.

Mỗi phòng nghỉ tại TTR Skyview Hotel đều được trang bị bàn làm việc, TV màn hình phẳng, phòng tắm riêng, ga trải giường, khăn tắm và ấm đun nước. Một số phòng có khu vực bếp ăn với lò vi sóng, tủ lạnh và lò nướng. Tất cả các phòng được bố trí khu vực ghế ngồi.

Hồ Xuân Hương nằm trong bán kính 2 km từ chỗ nghỉ trong khi Công viên Yersin cách đó 2,1 km. Sân bay gần nhất là sân bay Liên Khương, cách TTR Skyview Hotel 30 km, và chỗ nghỉ cung cấp dịch vụ đưa đón sân bay với một khoản phụ phí."
            });
            dsKS.Add(new Hotel
            {
                Name = "Hôtel Colline",
                CityID = 4,
                ImgSrc = "anh16.jpg",
                Address = "10 Phan Boi Chau Street, Ward 1, Đà Lạt, Việt Nam",
                Price = "2,001,000",
                Detail = @"Nằm ở trung tâm thành phố Đà Lạt, cách Quảng trường Lâm Viên 500 m, Hôtel Colline có quầy bar và các phòng với truy cập Wi-Fi miễn phí. Khách sạn này nằm cách Hồ Xuân Hương 200 m và cách công viên Yersin 500 m.

Các phòng tại đây được trang bị máy điều hòa, TV truyền hình cáp màn hình phẳng, ấm đun nước, chậu rửa vệ sinh, đồ vệ sinh cá nhân miễn phí, bàn làm việc, phòng tắm riêng và tầm nhìn ra quang cảnh thành phố. Ngoài ra còn có tủ quần áo.

Khách nghỉ tại Hôtel Colline có thể thưởng thức bữa sáng tự chọn.

Nhân viên thông thạo tiếng Anh và tiếng Việt tại lễ tân 24 giờ luôn sẵn sàng hỗ trợ quý khách.

Khách sạn cách Vườn hoa Đà Lạt 500 m và cách Thiền Viện Trúc Lâm 4 km. Sân bay gần nhất là sân bay Liên Khương, cách đó 23 km."
            });
            for (int i = 0; i < dsKS.Count; i++)
            {
                if (dsKS[i].CityID == city.ID)
                {
                    dsKS[i].Address = "Address: " + dsKS[i].Address;
                    dsKSTemp.Add(dsKS[i]);
                    //Console.WriteLine(dsKS[i].Address);
                }
            }
            InitializeComponent();
            contP.Title = city.Name;
            dsKhachSan.ItemsSource = dsKSTemp;
        }
        private void KhachSan_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Hotel forwa = (Hotel)e.SelectedItem;
            Console.WriteLine(forwa.Name, forwa.Address);

            Navigation.PushAsync(new HotelDetail(forwa));
        }
    }
}