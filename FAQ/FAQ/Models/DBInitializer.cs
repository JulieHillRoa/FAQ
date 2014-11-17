using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FAQ.Models
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<FAQDB>
    {
        protected override void Seed(FAQDB context)
        {
            var questions = new List<Questions>
            {

                new Questions {
                    Id = 0,
                    Categoryid = 2,
                    Date =new DateTime(2012, 05,30),
                    Question ="Kan dere få betaling på faktura ?",
                    Answer = "Dette er ikke en mulighet per nå, vi tar kun visa og bankekspress",
                    Isfequant = true
                },
                new Questions {
                    Id = 1,
                    Categoryid = 3,
                    Date =new DateTime(2013, 10, 11),
                    Question ="Er det mulig og gi gavekort til denne nettbutikken i gave ?",
                    Answer = "Dessverre er det ikke det per dagsdato, men det er noe vi kan vurdere å utvide nettbutikken med.",
                    Isfequant = true
                },
                new Questions {
                    Id = 2,
                    Categoryid = 0,
                    Date =new DateTime(2013, 12, 21),
                    Question ="Hvor lang tid vi normalt en levering ta fra betalingsdato ? ",
                    Answer = "Vi bruker to dager på utsendelse av lager, derretter tar det 1-5 dager etter hvor langt unna lageret vårt du bor",
                    Isfequant = true
                },
                new Questions {
                    Id = 3,
                    Categoryid = 3,
                    Date =new DateTime(2013, 05,30),
                    Question ="oihuk fghjkhgh fgh ",
                    Answer = "tfygu ijuhdfg kljh fgyuh økljikhj fghvj kljh",
                    Isfequant = true
                },
                new Questions {
                    Id = 4,
                    Categoryid = 1,
                    Date =new DateTime(2013, 04,19),
                    Question ="Om flaskene er knuste ved levering, hvordan får jeg nye?",
                    Answer = "Da refunderer vi pengene eller sender deg nye dagen etterpå. Ring service telefonen på 22 33 44 55 så ordner det seg.",
                    Isfequant = true
                },
                 new Questions {
                    Id = 5,
                    Categoryid = 3,
                    Date =new DateTime(2012, 02, 08),
                    Question ="Kan man søke jobb hos dere? ",
                    Answer = "Vi ansetter sjåfører, trenger kanskje en som er flink med ønonomi og liknende også",
                    Isfequant = true
                },
                new Questions {
                    Id = 6,
                    Categoryid = 0,
                    Date =new DateTime(2014, 03,06),
                    Question ="Leverer dere til slavbard ",
                    Answer = "Ja det gjør vi vettu ! ",
                    Isfequant = true
                },
                 new Questions {
                    Id = 7,
                    Categoryid = 3,
                    Date =new DateTime(2012, 11,15),
                    Question ="Kan dere få inn produkter ved å bestille ",
                    Answer = "Vi har ikke gjort dette til nå, men om du ringer oss på tlf 22 33 44 55 så kan det hende vi kan ordne dette",
                    Isfequant = true
                },
                new Questions {
                    Id = 8,
                    Categoryid = 3,
                    Date =new DateTime(2012, 09,30),
                    Question ="Hvordan skjekker dere aldersgrense ",
                    Answer = "Man må vise legitimasjon når varene kommer på døren",
                    Isfequant = true
                },
                 
                 new Questions {
                    Id = 9,
                    Categoryid = 2,
                    Date =new DateTime(2013, 10,30),
                    Question ="Om vinen er dårlig får jeg pengene tilbake ?",
                    Answer = "Da må du sende inn varen så må vi avgjøre om den er dårlig eller ikke. ",
                    Isfequant = true
                },
                 new Questions {
                    Id = 10,
                    Categoryid = 3,
                    Date =new DateTime(2014, 05,22),
                    Question ="Om jeg ikke husker passord hvordan får jeg nytt?",
                    Answer = "Om du ikke får et passord av oss ved å trykke på glemtpassord knappen må du ringe oss på 22 33 44 55",
                    Isfequant = true
                },
                new Questions {
                    Id = 11,
                    Categoryid = 1,
                    Date =new DateTime(2013, 05,30),
                    Question ="Hvor lang angrefrist har jeg?",
                    Answer = "3 ukers angrerett.",
                    Isfequant = true
                },
                 new Questions {
                    Id = 12,
                    Categoryid = 3,
                    Date =new DateTime(2012, 03,28),
                    Question ="Fåt ikke betalt med kortet mitt, hvorfor?",
                    Answer = null,
                    Isfequant = true,
                    email="snuble.vann@eksempel.com"
                },
                 new Questions {
                    Id = 13,
                    Categoryid = 0,
                    Date =new DateTime(2014, 06,08),
                    Question ="Hvor er lagret deres?",
                    Answer = "Dette er i oslo, men vi tenker på å utvide til Trondheim",
                    Isfequant = true
                }, new Questions {
                    Id = 14,
                    Categoryid = 0,
                    Date =new DateTime(2013, 12,11),
                    Question ="fnjkl flweq nlfwneq?",
                    Answer = "fnewj fewnfn fqwenfj jpfioewq",
                    Isfequant = true
                },
                 new Questions {
                    Id = 15,
                    Categoryid = 0,
                    Date =new DateTime(2013, 10,25),
                    Question ="mflkøe nfelwnq njfewqnkj?",
                    Answer = "vghkf lfhew bflewqvdasu ubhfqw høfqhuv qhi hø wqfhiqw fbwejq",
                    Isfequant = true
                },
                 new Questions {
                    Id = 16,
                    Categoryid = 1,
                    Date =new DateTime(2014, 05,30),
                    Question ="nflkaø ghoreqhgo grehgre høøoew",
                    Answer = "fnwe FILEW NFØEW BFIEW",
                    Isfequant = true
                },
                 new Questions {
                    Id = 17,
                    Categoryid = 1,
                    Date =new DateTime(2013, 03,05),
                    Question ="fnjw ngøew gbguiø hgweø fføweh ufwen?",
                    Answer = "ftygu fcgh vhb gyui køl gfyu dxf de.",
                    Isfequant = true
                },
                 new Questions {
                    Id = 18,
                    Categoryid = 1,
                    Date =new DateTime(2012, 03,29),
                    Question ="vewqu ih gi jpodwq ?",
                    Answer = "re tyu gvh xdf dfg ghbj iuh jkghj gu tfyu bh dtrf ijko bnj rdrt yui jknl iopitr dxfcgkl.",
                    Isfequant = true
                },
                 new Questions {
                    Id = 19,
                    Categoryid = 2,
                    Date =new DateTime(2014, 03,14),
                    Question ="fyg vmnb ukgyihl kj.nl oøijlgj gffcgvhbj ?",
                    Answer = "drtufy fjghuyi dfhcg huktr uiuolhk dresydt",
                    Isfequant = true
                },
                 new Questions {
                    Id = 20,
                    Categoryid = 2,
                    Date =new DateTime(2012, 06,30),
                    Question ="asdyuihk oiug yby hoiwhqoijpkød?",
                    Answer = "rytu gf rytu iop sred78yiu opidrtdfe dwq joihe",
                    Isfequant = true
                },
                 new Questions {
                    Id = 21,
                    Categoryid = 3,
                    Date =new DateTime(2013, 05,30),
                    Question ="iou fgv kmjøpl gytfg sdfbnm kølkytr fcg?",
                    Answer = null,
                    Isfequant = true,
                     email="julie.hei@eksempel.com"
                },
                 new Questions {
                    Id = 22,
                    Categoryid = 1,
                    Date =new DateTime(2012, 07,30),
                    Question ="Hvordan kan jeg se hvor pakken min er henn ?",
                    Answer = null,
                    Isfequant = true,
                     email="snuble.alkis@eksempel.com"
                },
                 new Questions {
                    Id = 23,
                    Categoryid = 0,
                    Date =new DateTime(2013, 05,30),
                    Question ="ghuk iojkn fgjh køl?",
                    Answer = null,
                    Isfequant = true,
                     email="tulle.vann@eksempel.com"
                },
                 new Questions {
                    Id = 24,
                    Categoryid = 1,
                    Date =new DateTime(2013, 05,30),
                    Question ="oi ftygh ljikh drtfkjljh df?",
                    Answer = null,
                    Isfequant = true,
                     email="hei.hei@eksempel.com"
                }, new Questions {
                    Id = 25,
                    Categoryid = 1,
                    Date =new DateTime(2013, 05,30),
                    Question ="jlk ftygljk dft iouhdfgh ?",
                    Answer = "3 ukers angrerett.",
                    Isfequant = true
                }, new Questions {
                    Id = 26,
                    Categoryid = 1,
                    Date =new DateTime(2014, 05,30),
                    Question ="ftyugih oij ftygh ljikgh j?",
                    Answer = null,
                    Isfequant = true,
                     email="haha.ha@eksempel.com"
                }, new Questions {
                    Id = 27,
                    Categoryid = 2,
                    Date =new DateTime(2013, 05,30),
                    Question ="jiluhi ftyj ijl fy?",
                    Answer = null,
                    Isfequant = true,
                     email="snuble.hm@eksempel.com"
                }, new Questions {
                    Id = 28,
                    Categoryid = 3,
                    Date =new DateTime(2013, 05,30),
                    Question ="poi yuhkk gfh yutdr fhjgv jkut ?",
                    Answer = null,
                    Isfequant = true,
                     email="veit.ikke@eksempel.com"
                },
                 new Questions {
                    Id = 29,
                    Categoryid = 3,
                    Date =new DateTime(2013, 05,30),
                    Question ="guy ioufyg ijgh ",
                    Answer = null,
                    Isfequant = true,
                     email="snuble.erlend@eksempel.com"
                },
                 new Questions {
                    Id = 30,
                    Categoryid = 1,
                    Date =new DateTime(2013, 05,30),
                    Question ="opi yui hgvh jkh hjklk tfhhj klj?",
                    Answer = "tyu oigvhb kljf tyijk dfg uiyt drtf jkh fgh khgd fyg hfgh khj ftyu ihu g nmjbhvg h ugyf.",
                    Isfequant = true
                },
                 new Questions {
                    Id = 31,
                    Categoryid = 2,
                    Date =new DateTime(2013, 05,30),
                    Question ="pfoewhfhiew iuh ighiu ofw?",
                    Answer = "kledhuy hfhwehfiu hiukjhf igvgierqh heivhivgieurho .",
                    Isfequant = true
                },
                 new Questions {
                    Id = 32,
                    Categoryid = 0,
                    Date =new DateTime(2014, 05,30),
                    Question ="luhifkgfkgeuayg uvfdu gvfdu ga?",
                    Answer = null,
                    Isfequant = true,
                     email="snuble.vann@eksempel.com"
                },
                 new Questions {
                    Id = 33,
                    Categoryid = 1,
                    Date =new DateTime(2013, 05,30),
                    Question ="foie hfewh oawj ofa ho?",
                    Answer = "fytgu u",
                    Isfequant = true
                },
                 new Questions {
                    Id = 34,
                    Categoryid = 2,
                    Date =new DateTime(2013, 05,30),
                    Question ="påoi iou gfh kl fgch hkj?",
                    Answer = "jahahshjdkflei jfdk jifl ",
                    Isfequant = true
                },
                 new Questions {
                    Id = 35,
                    Categoryid = 3,
                    Date =new DateTime(2013, 05,30),
                    Question ="yui bhjkh  ftg køsd hukj uhk ?",
                    Answer = "poå yug jkh fdg uyfd gjkn .",
                    Isfequant = true
                },
                 new Questions {
                    Id = 36,
                    Categoryid = 4,
                    Date =new DateTime(2013, 05,30),
                    Question ="gyiu kjl fg bjnk ?",
                    Answer = null,
                    Isfequant = true,
                     email="snuble.julie@eksempel.com"
                }, new Questions {
                    Id = 37,
                    Categoryid = 3,
                    Date =new DateTime(2013, 05,30),
                    Question ="gh iuhufeh jkldbhjk jfs ?",
                    Answer = "neajkwhfiwe bieq",
                    Isfequant = true
                }, new Questions {
                    Id = 38,
                    Categoryid = 0,
                    Date =new DateTime(2013, 05,30),
                    Question ="fbriuagf bailb lie?",
                    Answer = "fiodhifher øjoiofakjdwaef joifhoerhoijeo.",
                    Isfequant = true
                },
                 new Questions {
                    Id = 39,
                    Categoryid = 2,
                    Date =new DateTime(2013, 05,30),
                    Question ="opoi hiufgewuyfg lhfacyg kvafhkvh ?",
                    Answer = "ifj ufbhfck ajoi oigøah hguiahhgøa oøihøgaugh iuauhgahihføahg iuaiugviai.",
                    Isfequant = true
                },
                 new Questions {
                    Id = 40,
                    Categoryid = 3,
                    Date =new DateTime(2013, 05,30),
                    Question ="oahfl jjioah ?",
                    Answer = null,
                    Isfequant = true,
                     email="snuble.ole@eksempel.com"
                }, 
                 new Questions {
                    Id = 41,
                    Categoryid = 1,
                    Date = DateTime.Now,
                    Question ="Hvordan får jeg slettet ordren og fått pengene tilbake om jeg angrer på kjøpet? ",
                    Answer = "Vi har dessverre ikke noen integrert mulighet for dette enda på vår nettside, du må derfor ringe service telefonen vår på 22 33 44 55 så ordner vi det for deg.",
                    Isfequant = true
                },



            };
            questions.ForEach(q => context.Questions.Add(q));

            var catagry = new List<Categories>
            {
                new Categories{
                   CategoryId = 0,
                   Category = "Varelevering"
                },
                new Categories{
                    CategoryId = 1,
                    Category = "Angrerett"
                },
                new Categories{
                    CategoryId = 2,
                    Category = "Betaling"
                },
                new Categories{
                    CategoryId = 3,
                    Category="Generelt"
                }
            };
            catagry.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();
        }
    }
}