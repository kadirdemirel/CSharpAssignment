using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAssignment.Abstract;
using CSharpAssignment.Adapter;
using CSharpAssignment.Concrete;
using CSharpAssignment.Entities;

namespace CSharpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncuların bilgilerini giriyoruz.
            IMember member1 = new Member()
            {
                FirstName = "Abdulkadir",
                LastName = "Demirel",
                DateOfBirth = new DateTime(1998, 07, 17),
                NationalityId = "17201158454"
            };

            IMember member2 = new Member()
            {
                FirstName = "Engin",
                LastName = "Demiroğ",
                DateOfBirth = new DateTime(1985, 07, 17),
                NationalityId = "22222222222"
            };

            IMember member3 = new Member()
            {
                FirstName = "Başar",
                LastName = "Yüksel",
                DateOfBirth = new DateTime(1998, 07, 17),
                NationalityId = "33333333333"
            };
            //Oyuncu listesi oluşturup ekrana yazdırmak için liste oluşturuyorum.
            //Liste oluşturduktan sonra oyuncu verilerini listeye ekliyorum.
            //Listeye eklenen oyuncuları ekrana foreach döngüsüyle yazdırıyorum.
            List<IMember> members = new List<IMember>();
            members.Add(member1);
            members.Add(member2);
            members.Add(member3);
            Console.WriteLine("**************Oyuncu Listesi***************");
           int sira3 = 0;
            foreach (var memberss in members)
            {
                sira3 = sira3 + 1;
                Console.WriteLine(sira3+"-)"+memberss.FirstName + " " + memberss.LastName);
            }
            Console.WriteLine("*******************************************");
            //Burada ise kayıt işlemi yapıyorum.
            //Save() fonksiyonuna parametre olarak oyuncularımdan birini gönderiyorum.
            //Doğrulama olduğunda kayıt yapılıp ekrana kaydı yapılan kişinin adını yazdrıyorum.

            MemberManager memberManager = new SystemMemberManager(new MernisServiceAdapter());
            memberManager.Save(member1);
            Console.WriteLine("*******************************************");
            //Oyun bilgilerini giriyorum.
            IGameManager gameManager = new GameManager();
            IGame game1 = new Game { GameName = "Fifa 20", GameDescription = "Futbol", GamePrice = 400 };
            IGame game2 = new Game { GameName = "Fifa 19", GameDescription = "Futbol", GamePrice = 150 };
            IGame game3 = new Game { GameName = "Asphalt 8", GameDescription = "Araba Yarışı", GamePrice = 2000 };
            IGame game4 = new Game { GameName = "Pubg Mobile", GameDescription = "Savaş", GamePrice = 15000 };
            IGame game5 = new Game { GameName = "Seriu Sam3", GameDescription = "Savaş", GamePrice = 900 };

            //Kampanya bilgilerini giriyorum.
            ICampaignManager campaignManager = new CampaignManager();
            ICampaign campaign1 = new Campaign { CampaignName = "Süper Cuma", CampaignDetails = "Futbol Oyunlarında Geçerli", CampaignRate = 50 };
            ICampaign campaign2 = new Campaign { CampaignName = "Yılın İlk Fırsatları", CampaignDetails = "Tüm oyunlarda Geçerli", CampaignRate = 30 };
            List<ICampaign> campaigns = new List<ICampaign>();
            campaigns.Add(campaign1);
            campaigns.Add(campaign2);
            Console.WriteLine("*************Kampanya Listesi**************");
            int sira2 = 0;
            foreach (var campaignss in campaigns)
            {
                sira2 = sira2 + 1;
                Console.WriteLine(sira2 + "-)" + campaignss.CampaignName);
            }
           
            Console.WriteLine("******************************************");
        
            //Oluşturduğum oyunları listeye ekliyorum. 
            //Listeye eklediğim oyunları foreach döngüsüyle ekrana yazdırıyorum.
            List<IGame> games = new List<IGame>();
            games.Add(game1);
            games.Add(game2);
            games.Add(game3);
            games.Add(game4);
            games.Add(game5);

            Console.WriteLine("******************************************");
            Console.WriteLine("***************Oyun Listesi***************");
            int sira = 0;
            foreach (var gamess in games)
            {
                sira += 1;
                Console.WriteLine(sira + "-)" + gamess.GameName);
            }
            Console.WriteLine("******************************************");
            Console.WriteLine("Satın almak istediğiniz oyunu seçiniz.");
            //Bu satırdan sonrasında işi biraz etkileşimi yapmak istedim.
            //Try-Catch-Finaly yapısında Try-Catch yapısını kullandım.
            //Try-Catch kullanma sebebim programsal olarak hata olduğunda program sonlanmadan kullanıcıya uyarıda bulunmak için.
            //Goto ise belirtilen seçimler dışında kullanıcı farklı seçim yaparsa hata mesajı verildikten sonra tekrardan seçim yapmasını sağladım.
            //Burada oyuncuyu ben belirledim dışarıdan seçtirmedim.
            //Ancak oyun seçimini ve akabinde var olan kampanya seçimini kullanıdan aldım.

        Tekrar:
            int gamesecim = 0;
        Tekrar7:
            try
            {

                gamesecim = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Yanlış karakter girdiniz lütfen belirtilen rakamlardan birini seçiniz.");
                goto Tekrar7;
            }

            switch (gamesecim)
            {
                case 1:
                    {
                        Console.WriteLine("Seçtiğiniz oyun : " + game1.GameName);
                        Console.WriteLine("Bu oyunun " + campaigns.Count + " adet kampanyası vardır. Aşağıdakilerden birini seçiniz");
                        Console.WriteLine("1-) " + campaign1.CampaignName);
                        Console.WriteLine("2-) " + campaign2.CampaignName);
                    Tekrar2:
                        int campaignsecim = 0;
                    Tekrar8:
                        try
                        {
                            campaignsecim = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Yanlış karakter girdiniz lütfen belirtilen rakamlardan birini seçiniz.");
                            goto Tekrar8;
                        }
                        switch (campaignsecim)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Seçtiğiniz kampanya " + campaign1.CampaignName);
                                    gameManager.Sales(member1, game1, campaign1);
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Seçtiğiniz kampanya " + campaign2.CampaignName);
                                    gameManager.Sales(member1, game1, campaign2);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Yanlış Seçim");
                                    goto Tekrar2;
                                }

                        }


                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Seçtiğiniz oyun : " + game2.GameName);
                        Console.WriteLine("Bu oyunun " + campaigns.Count + " adet kampanyası vardır. Aşağıdakilerden birini seçiniz");
                        Console.WriteLine("1-) " + campaign1.CampaignName);
                        Console.WriteLine("2-) " + campaign2.CampaignName);
                    Tekrar3:
                        int campaignsecim2 = 0;
                    Tekrar9:
                        try
                        {
                            campaignsecim2 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Yanlış karakter girdiniz lütfen belirtilen rakamlardan birini seçiniz.");
                            goto Tekrar9;
                        }
                        switch (campaignsecim2)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Seçtiğiniz kampanya " + campaign1.CampaignName);
                                    gameManager.Sales(member1, game2, campaign1);
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Seçtiğiniz kampanya " + campaign2.CampaignName);
                                    gameManager.Sales(member1, game2, campaign2);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Yanlış Seçim");
                                    goto Tekrar3;
                                }

                        }

                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Seçtiğiniz oyun : " + game3.GameName);
                        Console.WriteLine("Bu oyunun 1 adet kampanyası vardır. Uygulamak istediğiniz kampanyayı seçiniz.");
                        Console.WriteLine("1-) " + campaign2.CampaignName);
                    Tekrar4:
                        int campaignsecim3 = 0;
                    Tekrar10:
                        try
                        {
                            campaignsecim3 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Yanlış karakter girdiniz lütfen belirtilen rakamlardan birini seçiniz.");
                            goto Tekrar10;
                        }
                        switch (campaignsecim3)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Seçtiğiniz kampanya " + campaign2.CampaignName);
                                    gameManager.Sales(member1, game3, campaign2);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Yanlış Seçim");
                                    goto Tekrar4;
                                }

                        }


                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Seçtiğiniz oyun : " + game4.GameName);
                        Console.WriteLine("Bu oyunun 1 adet kampanyası vardır. Uygulamak istediğiniz kampanyayı seçiniz.");
                        Console.WriteLine("1-) " + campaign2.CampaignName);
                    Tekrar5:
                        int campaignsecim4 = 0;
                    Tekrar11:
                        try
                        {
                            campaignsecim4 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Yanlış karakter girdiniz lütfen belirtilen rakamlardan birini seçiniz.");
                            goto Tekrar11;
                        }
                        switch (campaignsecim4)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Seçtiğiniz kampanya " + campaign2.CampaignName);
                                    gameManager.Sales(member1, game4, campaign2);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Yanlış Seçim");
                                    goto Tekrar5;
                                }

                        }


                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Seçtiğiniz oyun : " + game3.GameName);
                        Console.WriteLine("Bu oyunun 1 adet kampanyası vardır. Uygulamak istediğiniz kampanyayı seçiniz.");
                        Console.WriteLine("1-) " + campaign2.CampaignName);
                    Tekrar6:
                        int campaignsecim5 = 0;
                    Tekrar12:
                        try
                        {
                            campaignsecim5 = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Yanlış karakter girdiniz lütfen belirtilen rakamlardan birini seçiniz.");
                            goto Tekrar12;
                        }
                        switch (campaignsecim5)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Seçtiğiniz kampanya " + campaign2.CampaignName);
                                    gameManager.Sales(member1, game5, campaign2);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Yanlış Seçim");
                                    goto Tekrar6;
                                }

                        }


                        break;
                    }
                default:
                    {
                        Console.WriteLine("Yanlış seçim.");
                        goto Tekrar;

                    }

            }


            Console.ReadLine();
        }

    }
}
