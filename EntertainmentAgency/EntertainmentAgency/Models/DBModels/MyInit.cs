using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity;

namespace EntertainmentAgency.Models
{
    internal class MyInit<T> : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            Menu m = new Menu() { Name = "Budapest nutty", About = "Spicy chocolate and nut sponge cake soaked in a delicate caramel and butter cream", Price = 450, Image = "http://sweet-shop.com.ua/components/com_jshopping/files/img_products/full__tortorehovy.png" };
            Menu m1 = new Menu() { Name = "Wild berry", About = "Decor of seasonal berries and fruits.", Price = 515, Image = "http://sweet-shop.com.ua/components/com_jshopping/files/img_products/full________________________________________________________.png" };
            Menu m2 = new Menu() { Name = "Summer", About = "", Price = 720, Image = "http://sweet-shop.com.ua/components/com_jshopping/files/img_products/full_tort_letniy2.png" };
            Menu m3 = new Menu() { Name = "Makarons Meringue", About = "Color at choice: blue, pink, lime, orange, lilac, yellow.", Price = 655, Image = "http://sweet-shop.com.ua/components/com_jshopping/files/img_products/full_tort-gotoviy__2_.png" };
            Menu m4 = new Menu() { Name = "Carrot Cake", About = "Optionally, you can add a sugar business card with the inscription.", Price = 425, Image = "http://sweet-shop.com.ua/components/com_jshopping/files/img_products/full__morkovny.png" };
            Menu m5 = new Menu() { Name = "Macaron Coconut", About = "Delicate French pastry consisting of almond flour and a light mint filling. 15 gr", Price = 15, Image = "http://sweet-shop.com.ua/components/com_jshopping/files/img_products/full_Macaron-tutti.jpg" };
            Menu m6 = new Menu() { Name = "Tangerine in chocolate", About = "Tangerine in chocolate", Price = 18, Image = "http://sweet-shop.com.ua/components/com_jshopping/files/img_products/full_frukti-v-hokolade8.jpg" };
            Menu m7 = new Menu() { Name = "Marmalade Apricot", About = "Gentle apricot pulp boiled to the marmalade consistency. Ingredients: apricot puree, glucose syrup, citric acid, apple pectin, sugar", Price = 14, Image = "http://sweet-shop.com.ua/components/com_jshopping/files/img_products/full_marmelad-abrikos.jpg" };
            Menu m8 = new Menu() { Name = "Donut icing", About = "Biscuit donuts with chocolate icing. 80g", Price = 35, Image = "http://sweet-shop.com.ua/components/com_jshopping/files/img_products/full_poncik...jpg" };
            Menu m9 = new Menu() { Name = "Tart Marshmallow", About = "Tart Marshmallow 125 g", Price = 39, Image = "http://sweet-shop.com.ua/components/com_jshopping/files/img_products/full_tartaletka-ygodnay__2_.jpg" };
            Menu m10 = new Menu() { Name = "Croissant with a cherry", About = "Croissant with a cherry. 100 g", Price = 19, Image = "http://sweet-shop.com.ua/components/com_jshopping/files/img_products/full_kruasan3.png" };
            context.Menu.AddRange(new List<Menu>() { m2, m1, m4, m3, m5, m6, m7, m8, m9, m10 });

            TypeOfEntertainment t1 = new TypeOfEntertainment() { Type = "Birthday", Img = "https://blog.serenataflowers.com/pollennation/wp-content/uploads/2016/08/Birthday-messages-for-sisterFT.jpg" };
            TypeOfEntertainment t2 = new TypeOfEntertainment() { Type = "Wedding", Img = "https://image.nola.com/home/nola-media/width600/img/crime_impact/photo/wedding-rings-stockjpg-73b7c71f199ac617.jpg" };
            TypeOfEntertainment t3 = new TypeOfEntertainment() { Type = "Rave", Img = "https://cdn.shopify.com/s/files/1/0982/0722/files/6-1-2016_5-49-53_PM_1024x1024.jpg?7174960393118038727" };
            TypeOfEntertainment t4 = new TypeOfEntertainment() { Type = "Graduation", Img = "https://www.thespruce.com/thmb/xg3OPV5BkV_Ow-iE4mR46dxg1Xw=/450x0/filters:no_upscale():max_bytes(150000):strip_icc()/Grad-Party-Ideas-5816a2a95f9b581c0b77c25d.jpg" };
            TypeOfEntertainment t5 = new TypeOfEntertainment() { Type = "New Year", Img = "https://dkru86weszx9t.cloudfront.net/blog/wp-content/uploads/2017/12/Happy-New-Year.jpg" };
            context.TypeOfEntertainments.AddRange(new List<TypeOfEntertainment>() { t1, t2, t3, t4, t5 });

            Design d1 = new Design() { typeOfEntertainment = t5, Img = "https://www.picturesboss.com/?d=laH-fLos3eFmVVpMuOaI2-5yk84RUJKn6t-QjuipLJCOq6uFmw6YlBfGLncVuoqNrBjsyAbdZKueEZxAzQOYsQ" };
            Design d2 = new Design() { typeOfEntertainment = t5, Img = "http://1.bp.blogspot.com/-2WUuYYCfKrM/Uqm3DfGWIiI/AAAAAAAABPA/zuPEURNxMzs/s1600/home+design+for+christmas+and+new+year+2014-6.jpg" };
            Design d3 = new Design() { typeOfEntertainment = t5, Img = "https://www.gestablishment.com/wp-content/uploads/2017/06/chinese-decor-ideas1.jpg" };
            Design d4 = new Design() { typeOfEntertainment = t5, Img = "https://www.lushome.com/wp-content/uploads/2010/12/table-setting-decoration-xmas-new-year-party.gif" };
            Design d5 = new Design() { typeOfEntertainment = t5, Img = "https://warkacider.com/wp-content/uploads/2017/05/Sweet-christmas-and-new-years-party-decorations-ideas-with-silver-candelabra-and-white-christmas-tree-charming-table-arrangement-for-christmas-and-new-year-eve-party-decoration-for-living-room.jpg" };

            Design d6 = new Design() { typeOfEntertainment = t4, Img = "http://www.hurricanekatrinainformation.com/wp-content/uploads/2018/05/backyard-graduation-party-decorating-ideas-lovely-sweet-16-backyard-party-candle-ceremony-set-up-winter-wonderland-8g3-of-backyard-graduation-party-decorating-ideas-9z8.jpg" };
            Design d7 = new Design() { typeOfEntertainment = t4, Img = "https://i.pinimg.com/originals/c8/24/15/c824158c3f9fd8eb674ac33c7e6fd930.gif" };

            Design d8 = new Design() { typeOfEntertainment = t3, Img = "https://images1.laweekly.com/imager/u/original/6631988/raves-return-los-angeles-convention.jpg" };
            Design d9 = new Design() { typeOfEntertainment = t3, Img = "https://res.cloudinary.com/jerrick/image/upload/f_auto,fl_progressive,q_auto,c_fit,w_1100/qilewyuhuczkyoobfy6a" };
            Design d10 = new Design() { typeOfEntertainment = t3, Img = "https://www.latimes.com/resizer/-OGJPoiTwCo-VWMcR3PkDRVYxrw=/1400x0/arc-anglerfish-arc2-prod-tronc.s3.amazonaws.com/public/FV34AVMUQ5GHDNLIAUHL23OPSI.jpg" };

            Design d11 = new Design() { typeOfEntertainment = t2, Img = "https://assets.marthastewartweddings.com/styles/wmax-1500/d57/joanna-kyle-real-weddings-reception-009023-r1-001-d111223/joanna-kyle-real-weddings-reception-009023-r1-001-d111223_horiz.jpg?itok=62RtiU3t" };
            Design d12 = new Design() { typeOfEntertainment = t2, Img = "https://media-api.xogrp.com/images/b4bda016-b894-4366-947d-a054c3f66fe1~rs_768.h" };
            Design d13 = new Design() { typeOfEntertainment = t2, Img = "https://www.queenweddingdecor.com/wp-content/uploads/2018/07/ceremony_20180721.jpg" };
            Design d14 = new Design() { typeOfEntertainment = t2, Img = "https://thegardenvenue.co.za/wp-content/uploads/2018/09/TGV-Wedding-Decor-5.jpg" };

            Design d15 = new Design() { typeOfEntertainment = t1, Img = "https://i.etsystatic.com/15729766/d/il/cc888c/1613017087/il_340x270.1613017087_gtsh.jpg?version=0" };
            Design d16 = new Design() { typeOfEntertainment = t1, Img = "https://ae01.alicdn.com/kf/HTB1mIYYioR1BeNjy0Fmq6z0wVXas/Birthday-Decor-Paper-Pompom-Flower-Folding-Fan-Party-Decoration-Happy-Birthday-Banner-Decoration-Party-Supplies.jpg_640x640.jpg" };
            Design d17 = new Design() { typeOfEntertainment = t1, Img = "https://www.theperfectgift.ae/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/b/i/birthday-balloon-letters-event-dubai.jpg" };
            Design d18 = new Design() { typeOfEntertainment = t1, Img = "http://ngretailsummitla.com/wp-content/uploads/2018/06/modest-ideas-girl-baby-shower-table-decorations-inspirational-pink-and-gold-baby-shower-table-decorations-3.jpg" };
            Design d19 = new Design() { typeOfEntertainment = t1, Img = "https://acraftedpassion.com/wp-content/uploads/2018/01/black-white-birthday-party-feature.jpg" };
            Design d20 = new Design() { typeOfEntertainment = t1, Img = "https://ae01.alicdn.com/kf/HTB1KHPMSpXXXXcBXXXXq6xXFXXXK/Baby-Shower-Boy-Girl-Birthdays-Party-Decorations-DIY-Kids-Party-Decor-Blue-Theme-Birthday-Holiday-Supplier.jpg_640x640.jpg" };
            context.Designes.AddRange(new List<Design>() { d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17, d18, d19, d20 });


            Employeer e1 = new Employeer() { Email = "mail1@ukr.net", Name = "Alexander Pumpkin", Phone = "(066) 705-33-20" };
            Employeer e2 = new Employeer() { Email = "qwerty@mail.ru", Name = "Danylyuk Alexander", Phone = "(097) 988-90-09" };
            Employeer e3 = new Employeer() { Email = "hello@gmail.co", Name = "Anna Vovk", Phone = "(068) 768-84-83" };
            Employeer e4 = new Employeer() { Email = "mail111@list.ru", Name = "Tatyana Novak", Phone = "(097) 854-57-76" };
            Employeer e5 = new Employeer() { Email = "gmail@ukr.net", Name = "Svetlana Raichuk", Phone = "(093) 143-73-96" };
            Employeer e6 = new Employeer() { Email = "mail3.mail@gmail.com", Name = "Tatiana Kyrchuk", Phone = "(050) 883-60-22" };
            Employeer e7 = new Employeer() { Email = "myemail@gmail.com", Name = "Sergiy Sobolevsky", Phone = "(093) 099-30-00" };
            context.Employeers.AddRange(new List<Employeer>() { e1, e2, e3, e4, e5, e6, e7 });


            Competition c1 = new Competition() { Name = "Photographer", About = "Photographers, known for their creative thinking and artistic approach to photography", Price =7000, Employeers = {e1,e5 } };
            Competition c2 = new Competition() { Name = "Video shooting", About = "High - quality shooting of a day that is important for you will bring joy in the future", Price =13000, Employeers = {e2 } };
            Competition c3 = new Competition() { Name = "Musician", About = "Any music to your liking and a pleasant holiday is guaranteed", Price =15000, Employeers = {e7,e3,e1 } };
            Competition c4 = new Competition() { Name = "Tamada", About = "This person will raise your mood and make you remember the day for life", Price =10000, Employeers = {e4,e6 } };
            Competition c5 = new Competition() { Name = "Animators", About = "Fun jokes and interesting contests are guaranteed by our animators", Price =8000, Employeers = { e3, e6} };
            context.Competitions.AddRange(new List<Competition>() { c1, c2, c3, c4, c5});
            

            context.Idxes.Add(new Idx() { index = 0 });





            context.SaveChanges();
            //base.Seed(context);
        }
    }
}