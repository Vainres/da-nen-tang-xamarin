using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TH2
{
    public class Animal
    {
        public string Name { get; set; }
        public int RaceID { get; set; }
        public string ImgSrc { get; set; }
        public string Detail { get; set; }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RaceListB3 : ContentPage
    {
        private List<Animal> dsDV;

        public RaceListB3(Race race)
        {
            dsDV = new List<Animal>();
            List<Animal> dsDVTemp = new List<Animal>();
            dsDV.Add(new Animal
            {
                Name = "Samoyed",
                RaceID = 1,
                ImgSrc = "cho1.jpg",
                Detail = @"Samoyed là một giống chó săn có nguồn gốc từ vùng Siberia, đây là giống chó có bộ lông trắng tinh như tuyết cùng tính cách mang nhiều đặc điểm của chó sói là những đặc trưng nổi bật của giống chó này. Samoyed có nghĩa là giống chó có khả năng tự tìm ra thức ăn. Samoyed từng là chó kéo xe trượt tuyết trước khi trở thành bạn dành cho giới thượng lưu và hợp thời trang như ngày nay, nó cũng từng được những người thợ săn và đánh cá nuôi. Trang nhã và lanh lợi, giống chó này ngày nay trở nên một trong những giống chó mốt nhất của những người yêu chó và được gọi là Nàng Bạch tuyết của rừng Taiga.[1]

Đây là một giống chó rất siêng năng. Nó có thể sủa bất cứ lúc nào khi có vật tiếp cận nó.[2] Chúng là giống chó có giá thành cao. Giá cả của loài chó này phụ thuộc nhiều vào ngoại hình, tính cách của chúng. Có khi người ta có thể tìm được những chú chó giá 1.000 USD, nhưng cũng có lúc phải trả gấp 11 lần con số này để sở hữu một con.[3] Giống chó này còn rất thân thiện và nổi tiếng ham chơi.[4"
            });

            dsDV.Add(new Animal{ Name = "Shiba", RaceID = 1, ImgSrc = "cho2.jpg",Detail = @"Shiba Inu (柴犬 (sài khuyển)?) là loại chó nhỏ nhất trong sáu giống chó nguyên thủy và riêng biệt đến từ Nhật Bản.[1] Chúng là một giống chó nhỏ, nhanh nhẹn và thích hợp với địa hình miền núi, Shiba Inu ban đầu được nuôi để săn bắt.[1][2] Ngoại hình của chúng gần giống nhưng nhỏ hơn so với giống Akita Inu. Đây là một trong số ít giống chó cổ xưa vẫn còn tồn tại cho đến ngày nay.[3]

Shiba là một trong sáu giống chó điển hình của Nhật Bản, cũng như Hokkaido, Kishu, Shikoku, Kai và Akita. Trong những giống chó này, Shiba là nhỏ nhất về thể chất." });
            dsDV.Add(new Animal { Name = "Corgi", RaceID = 1, ImgSrc = "cho3.webp", Detail = @"Chó Corgi Pembroke Wales là giống chó chăn gia súc có nguồn gốc từ Pembrokeshire, xứ Wales. Nó là một trong hai giống được biết đến với tên gọi chung là Chó Corgi xứ Wales. Giống chó còn lại là giống Chó Corgi Cardigan Wales và cả hai đều có tổ tiên là giống chó đuôi cuộn kiểu Bắc Cực." });
            dsDV.Add(new Animal { Name = "Husky Sibir", RaceID = 1, ImgSrc = "cho4.jpg", Detail = @"Chó Husky Sibir là một giống chó cỡ trung thuộc nòi chó kéo xe có nguồn gốc từ vùng Đông Bắc Sibir, Nga. Xét theo đặc điểm di truyền, chó Husky được xếp vào dòng Spitz. Chó Husky có hai lớp lông dày, tai dựng hình tam giác và thường có những điểm nhận dạng khác nhau trên lông. " });
            dsDV.Add(new Animal { Name = "Mèo chân đen", RaceID = 2, ImgSrc = "meo1.jpg", Detail = @"Mèo chân đen là một loài mèo nhỏ thuộc Chi Mèo trong họ Mèo. Chúng là loài mèo hoang nhỏ nhất, và cũng là một trong những loài động vật ăn thịt ít được nghiên cứu nhất ở châu Phi. Chúng được liệt vào danh sách loài dễ bị tổn thương bởi Liên minh Bảo tồn Thiên nhiên Quốc tế từ năm 2002." });
            dsDV.Add(new Animal { Name = "Mèo lông ngắn Anh", RaceID = 2, ImgSrc = "meo2.jpg", Detail = @"Mèo lông ngắn Anh là phiên bản nhân giống có chọn lọc của mèo nhà Anh truyền thống với những đặc điểm như thân hình mũm mĩm, lông ngắn và dày cùng với khuôn mặt to. Màu sắc phổ biến nhất là màu xám xanh với mắt màu vàng đồng, nhưng ngoài ra vẫn còn nhiều màu sắc và hoa văn khác nhau." });
            dsDV.Add(new Animal { Name = "Mèo lông dài Anh", RaceID = 2, ImgSrc = "meo3.jpg", Detail = @"Nguồn gốc của nòi mèo này là một giống mèo Anh có lông dài. Giống mèo thủy tổ này sau nhiều đời lai với những giống mèo lông dài ngoại nhập khác đã hấp thu nhiều yếu tố di truyền của các nòi mèo lông dài ở Ba Tư và hình thành kiểu hình với bộ lông dài và dày đặc trưng - thậm chí còn dày hơn cả những con mèo Ba Tư nguyên thủy. Ở đây mèo lông dài Anh và mèo Ba Tư có một mối quan hệ hơi rắc rối: trong thế kỷ 19 và đầu thế kỷ 20, mèo Ba Tư được coi như là những cá thể lông dài của mèo lông ngắn Anh; mãi đến nửa cuối thế kỷ 20 khi nòi mèo Ba Tư xuất hiện kiểu hình lông ngắn thì sự đánh đồng này mới chấm dứt. Từ đó, phiên bản mèo lông dài Ba Tư được đặt tên là mèo lông dài ngoại nhập và cái tên mèo lông dài Anh được trả về đúng chỗ của nó.[1]Nói tóm lại,mèo lông dài Anh là phiên bản lông dài của mèo lông ngắn Anh.[2] Giống như đồng hương lông ngắn,mèo lông dài Anh có đầu vuông và rộng.Mặc dù được công nhận ở một số nước khác nhưng mèo lông dài Anh không được công nhận rộng rãi ngay tại quê hương của nó." });
            dsDV.Add(new Animal { Name = "Mèo Maine Coon", RaceID = 2, ImgSrc = "meo4.jpg", Detail = @"Maine Coon hay mèo lông dài Mỹ là một nòi mèo nhà có đặc điểm kiểu hình đặc trưng và có kỹ năng săn mồi đáng nể. Nó là một trong những nòi mèo tự nhiên cổ xưa nhất ở Bắc Mỹ, là nòi bản địa của bang Maine và được bang này chọn là động vật đại diện cho mình. " });

            dsDV.Add(new Animal { Name = "Cáo fennec", RaceID = 3, ImgSrc = "cao1.jpg", Detail = @"Cáo fennec hay cáo sa mạc là một loài cáo mắt nhỏ hoạt động về đêm phân bố ở sa mạc Sahara thuộc Bắc Phi. Điểm đặc biệt của loài là đôi tai lớn bất thường, phục vụ cho mục đích tản nhiệt." });
            dsDV.Add(new Animal { Name = "Cáo tuyết Bắc Cực", RaceID = 3, ImgSrc = "cao2.jpg", Detail = @"Cáo tuyết Bắc Cực (Vulpes lagopus), còn có tên cáo trắng, cáo tuyết hay cáo Bắc Cực, là một loài cáo nhỏ có nguồn gốc từ vùng Bắc Cực ở Bắc bán cầu và thường sống tại quần xã ở đài nguyên Bắc Cực.[1][7] Loài cáo này thích nghi tốt với môi trường lạnh. Chúng sở hữu bộ lông dày có màu nâu vào mùa hạ và chuyển sang màu trắng vào mùa đông. Chiều dài cơ thể vào khoảng 46 đến 68 cm (18 đến 27 in) cùng với thân hình cong tròn giúp chúng giảm thiểu được sự truyền nhiệt từ cơ thể ra ngoài không khí.

Cáo Bắc Cực ăn thịt mọi sinh vật nhỏ mà chúng tìm thấy, bao gồm chuột Lemming, chuột đồng, hải cẩu đeo vòng non, các loài cá, thủy cầm và cả chim biển. Chúng còn ăn các xác thối, quả mọng, rong biển, côn trùng và những loài động vật không xương sống nhỏ khác. Cáo Bắc Cực hình thành những đôi đơn giao phối trong mùa sinh sản và chúng sẽ ở cùng nhau để nuôi dưỡng con non trong các hang dưới lòng đất. Đôi khi, những thành viên khác trong gia đình sẽ giúp chúng thực hiện công việc này." });
            dsDV.Add(new Animal { Name = "Cáo đỏ", RaceID = 3, ImgSrc = "cao3.jpg", Detail = @"Cáo đỏ (Vulpes vulpes) là loài lớn nhất trong chi Cáo, và là một trong những thành viên phân bố rộng rãi nhất của Bộ Ăn thịt, có mặt trên toàn bộ Bắc Bán cầu bao gồm hầu hết Bắc Mỹ, Châu Âu và Châu Á cộng với một phần của Bắc Phi. Phạm vi sinh sống của chúng tăng lên song song với sự mở rộng của con người, khi được du nhập vào Úc, nơi chúng bị xem là một loài gây hại cho các động vật có vú và các loài chim bản địa. Chúng được đánh giá là ít quan tâm bởi IUCN.[1]" });
            dsDV.Add(new Animal { Name = "Cáo xám", RaceID = 3, ImgSrc = "cao4.jpg", Detail = @"Cáo xám (Urocyon cinereoargenteus) là một loài động vật có vú trong họ Chó, bộ Ăn thịt. Loài này được Schreber mô tả năm 1775.[2] Chúng phân bố rộng khắp nửa nam của Bắc Mỹ từ nam Canada đến phía bắc của Nam Mỹ (Venezuela và Colombia). Loài này và họ hàng gần của nó Urocyon littoralis là những thành viên còn sinh tồn duy nhất trong chi Urocyon, chi này được xem là nhóm nguyên thủy nhất của các loài trong họ chó còn sinh tồn.[3] Nó từng là loài cáo phổ biến nhất vùng phía đông, và vẫn được tìm thấy ở đó,[4][5][6] với sự phát triển của con người làm cho cáo đỏ trở nên chiếm ưu thế hơn. Các bang vùng Thái Bình Dương vẫn có loài cáo xám này chiếm phổ biến." });

            dsDV.Add(new Animal { Name = "Vàng anh Á Âu", RaceID = 4, ImgSrc = "chim1.jpg", Detail = @"Vàng Anh Á Âu ban đầu được Carl Linnaeus mô tả trong chi Coracias (chứa các loài sả rừng). Cho tới năm 2011 nó được cho là đồng loài với vàng anh Ấn Độ cho đến khi được chia tách.[3] Một quần thể nhỏ có tên gọi turkestanica được Charles Vaurie coi là không thể phân biệt được với O. o. oriolus.[4] Các tên gọi khác còn có vàng anh châu Âu và vàng anh Tây Á Âu." });
            dsDV.Add(new Animal { Name = "Sơn ca", RaceID = 4, ImgSrc = "chim2.jpg", Detail = @"Sơn ca hay Sơn ca phương Đông (danh pháp hai phần: Alauda gulgula) là một loài chim thuộc Họ Sơn ca. Loài này sinh sống ở Nam Á và Đông Nam Á. Giống như các loài sơn ca khác, nó được tìm thấy trong khu vực đồng cỏ thưa - thường gần các thủy vực - nơi nó ăn hạt và côn trùng.

Chúng thường bay vút lên bầu trời và cất tiếng hót trước khi liệng thấp xuống, chúng cũng có thể vừa bay liệng vừa hót để thu hút bạn tình.

Chúng có cơ thể dài khoảng 16 cm. Chúng có bộ lông sọc, màu vàng nâu trên, với lông đuôi màu trắng bên ngoài và mào lông ngắn. Con trống và con mái có bề ngoài tương tự." });
            dsDV.Add(new Animal { Name = "Chìa vôi trắng", RaceID = 4, ImgSrc = "chim3.jpg", Detail = @"Chìa vôi trắng (tên khoa học: Motacilla alba) là một loài chim thuộc họ Chìa vôi (Motacilidae). Loài chim này phân bố rất rộng tại cả châu Á, châu Âu và một phần của Bắc Phi. Chúng thích sinh sống tại những môi trường nông thôn mở, thường là gần các khu vực nguồn nước, các khu dân cư của con người kể cả các thành phố. Khả năng thích nghi với môi trường của chúng là rất tốt. Loài chìa vôi trắng này cũng được chọn làm biểu tượng quốc gia của đất nước Latvia (châu Âu). Do có phạm vi phân bố rộng nên hiện có khá nhiều phân loài của chúng đã được ghi nhận." });
            dsDV.Add(new Animal { Name = "Chào mào", RaceID = 4, ImgSrc = "chim4.jpg", Detail = @"Chào mào (Pycnonotus jocosus) là một loài chim thuộc bộ Sẻ phân bố ở châu Á. Nó là một thành viên của họ Chào mào. Nó là một loài động vật ăn quả thường trú được tìm thấy chủ yếu ở châu Á nhiệt đới. Nó đã được đưa bởi con người vào nhiều khu vực nhiệt đới trên thế giới, nơi các quần thể đã tự hình thành. Nó ăn trái cây và côn trùng nhỏ. Chúng dễ thấy đậu trên cây và kêu to ba hoặc bốn nốt. Chúng rất phổ biến trong rừng đồi và vườn đô thị trong phạm vi của chúng. Chào mào có một cái mào dễ nhận biết, hai má trắng và phía trên mảng trắng là màu đỏ do đó chúng có tên tiếng Anh là râu đỏ (red-whiskered). Tại Việt nam, tùy theo vùng miền mà chúng có tên gọi khác nhau: chóp mào, hoành hoạch mồng, chóp mũ đỏ, đít đỏ... nhưng tên thông dụng nhất vẫn là chào mào." });

            for (int i = 0; i < dsDV.Count; i++)
            {
                if (dsDV[i].RaceID == race.ID)
                {
                    dsDVTemp.Add(dsDV[i]);
                }
            }
            InitializeComponent();
            contP.Title = race.Name;
            dsDongV.ItemsSource = dsDVTemp;
        }

        private void Animal_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Animal forwa = (Animal)e.SelectedItem;

            Navigation.PushAsync(new AnimalDetail(forwa));
        }

    }
}