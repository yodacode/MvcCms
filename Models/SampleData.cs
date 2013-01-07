﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcCms.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<CmsEntities>
    {
        protected override void Seed(CmsEntities context)
        {
            var tags = new List<Tag>
            {
                new Tag { Name = "Webdesign" },
                new Tag { Name = "Graphisme" },
                new Tag { Name = "Développement" },
                new Tag { Name = "Réseaux" },
                new Tag { Name = "Gestion" },
                new Tag { Name = "Marketing" },
                new Tag { Name = "Java" },
                new Tag { Name = "Mobile" },
                new Tag { Name = "Framework" },
                new Tag { Name = "CMS" }
            };

            var keys = new List<Key>
            {
                new Key { Name = "huhu" },
                new Key { Name = "hihi" },
                new Key { Name = "lol" },
            };



            var authors = new List<Author>
            {
                new Author { Name = "Aaron Copland & London Symphony Orchestra" },
                new Author { Name = "Aaron Goldberg" },
                new Author { Name = "AC/DC" },
                new Author { Name = "Accept" },
                new Author { Name = "Adrian Leaper & Doreen de Feis" },
                new Author { Name = "Aerosmith" },
                new Author { Name = "Aisha Duo" },
                new Author { Name = "Alanis Morissette" },
                new Author { Name = "Alberto Turco & Nova Schola Gregoriana" },
                new Author { Name = "Alice In Chains" },
                new Author { Name = "Amy Winehouse" },
                new Author { Name = "Anita Ward" },
                new Author { Name = "Antônio Carlos Jobim" },
                new Author { Name = "Apocalyptica" },
                new Author { Name = "Audioslave" },
                new Author { Name = "Barry Wordsworth & BBC Concert Orchestra" },
                new Author { Name = "Berliner Philharmoniker & Hans Rosbaud" },
                new Author { Name = "Berliner Philharmoniker & Herbert Von Karajan" },
                new Author { Name = "Billy Cobham" },
                new Author { Name = "Black Label Society" },
                new Author { Name = "Black Sabbath" },
                new Author { Name = "Boston Symphony Orchestra & Seiji Ozawa" },
                new Author { Name = "Britten Sinfonia, Ivor Bolton & Lesley Garrett" },
                new Author { Name = "Bruce Dickinson" },
                new Author { Name = "Buddy Guy" },
                new Author { Name = "Caetano Veloso" },
                new Author { Name = "Cake" },
                new Author { Name = "Calexico" },
                new Author { Name = "Cássia Eller" },
                new Author { Name = "Chic" },
                new Author { Name = "Chicago Symphony Orchestra & Fritz Reiner" },
                new Author { Name = "Chico Buarque" },
                new Author { Name = "Chico Science & Nação Zumbi" },
                new Author { Name = "Choir Of Westminster Abbey & Simon Preston" },
                new Author { Name = "Chris Cornell" },
                new Author { Name = "Christopher O'Riley" },
                new Author { Name = "Cidade Negra" },
                new Author { Name = "Cláudio Zoli" },
                new Author { Name = "Creedence Clearwater Revival" },
                new Author { Name = "David Coverdale" },
                new Author { Name = "Deep Purple" },
                new Author { Name = "Dennis Chambers" },
                new Author { Name = "Djavan" },
                new Author { Name = "Donna Summer" },
                new Author { Name = "Dread Zeppelin" },
                new Author { Name = "Ed Motta" },
                new Author { Name = "Edo de Waart & San Francisco Symphony" },
                new Author { Name = "Elis Regina" },
                new Author { Name = "English Concert & Trevor Pinnock" },
                new Author { Name = "Eric Clapton" },
                new Author { Name = "Eugene Ormandy" },
                new Author { Name = "Faith No More" },
                new Author { Name = "Falamansa" },
                new Author { Name = "Foo Fighters" },
                new Author { Name = "Frank Zappa & Captain Beefheart" },
                new Author { Name = "Fretwork" },
                new Author { Name = "Funk Como Le Gusta" },
                new Author { Name = "Gerald Moore" },
                new Author { Name = "Gilberto Gil" },
                new Author { Name = "Godsmack" },
                new Author { Name = "Gonzaguinha" },
                new Author { Name = "Göteborgs Symfoniker & Neeme Järvi" },
                new Author { Name = "Guns N' Roses" },
                new Author { Name = "Gustav Mahler" },
                new Author { Name = "Incognito" },
                new Author { Name = "Iron Maiden" },
                new Author { Name = "James Levine" },
                new Author { Name = "Jamiroquai" },
                new Author { Name = "Jimi Hendrix" },
                new Author { Name = "Joe Satriani" },
                new Author { Name = "Jorge Ben" },
                new Author { Name = "Jota Quest" },
                new Author { Name = "Judas Priest" },
                new Author { Name = "Julian Bream" },
                new Author { Name = "Kent Nagano and Orchestre de l'Opéra de Lyon" },
                new Author { Name = "Kiss" },
                new Author { Name = "Led Zeppelin" },
                new Author { Name = "Legião Urbana" },
                new Author { Name = "Lenny Kravitz" },
                new Author { Name = "Les Arts Florissants & William Christie" },
                new Author { Name = "London Symphony Orchestra & Sir Charles Mackerras" },
                new Author { Name = "Luciana Souza/Romero Lubambo" },
                new Author { Name = "Lulu Santos" },
                new Author { Name = "Marcos Valle" },
                new Author { Name = "Marillion" },
                new Author { Name = "Marisa Monte" },
                new Author { Name = "Martin Roscoe" },
                new Author { Name = "Maurizio Pollini" },
                new Author { Name = "Mela Tenenbaum, Pro Musica Prague & Richard Kapp" },
                new Author { Name = "Men At Work" },
                new Author { Name = "Metallica" },
                new Author { Name = "Michael Tilson Thomas & San Francisco Symphony" },
                new Author { Name = "Miles Davis" },
                new Author { Name = "Milton Nascimento" },
                new Author { Name = "Mötley Crüe" },
                new Author { Name = "Motörhead" },
                new Author { Name = "Nash Ensemble" },
                new Author { Name = "Nicolaus Esterhazy Sinfonia" },
                new Author { Name = "Nirvana" },
                new Author { Name = "O Terço" },
                new Author { Name = "Olodum" },
                new Author { Name = "Orchestra of The Age of Enlightenment" },
                new Author { Name = "Os Paralamas Do Sucesso" },
                new Author { Name = "Ozzy Osbourne" },
                new Author { Name = "Page & Plant" },
                new Author { Name = "Paul D'Ianno" },
                new Author { Name = "Pearl Jam" },
                new Author { Name = "Pink Floyd" },
                new Author { Name = "Queen" },
                new Author { Name = "R.E.M." },
                new Author { Name = "Raul Seixas" },
                new Author { Name = "Red Hot Chili Peppers" },
                new Author { Name = "Roger Norrington, London CMS Players" },
                new Author { Name = "Royal Philharmonic Orchestra & Sir Thomas Beecham" },
                new Author { Name = "Rush" },
                new Author { Name = "Santana" },
                new Author { Name = "Scholars Baroque Ensemble" },
                new Author { Name = "Scorpions" },
                new Author { Name = "Sergei Prokofiev & Yuri Temirkanov" },
                new Author { Name = "Sir Georg Solti & Wiener Philharmoniker" },
                new Author { Name = "Skank" },
                new Author { Name = "Soundgarden" },
                new Author { Name = "Spyro Gyra" },
                new Author { Name = "Stevie Ray Vaughan & Double Trouble" },
                new Author { Name = "Stone Temple Pilots" },
                new Author { Name = "System Of A Down" },
                new Author { Name = "Temple of the Dog" },
                new Author { Name = "Terry Bozzio, Tony Levin & Steve Stevens" },
                new Author { Name = "The 12 Cellists of The Berlin Philharmonic" },
                new Author { Name = "The Black Crowes" },
                new Author { Name = "The Cult" },
                new Author { Name = "The Doors" },
                new Author { Name = "The King's Singers" },
                new Author { Name = "The Police" },
                new Author { Name = "The Posies" },
                new Author { Name = "The Rolling Stones" },
                new Author { Name = "The Who" },
                new Author { Name = "Tim Maia" },
                new Author { Name = "Ton Koopman" },
                new Author { Name = "U2" },
                new Author { Name = "UB40" },
                new Author { Name = "Van Halen" },
                new Author { Name = "Various authors" },
                new Author { Name = "Velvet Revolver" },
                new Author { Name = "Vinícius De Moraes" },
                new Author { Name = "Wilhelm Kempff" },
                new Author { Name = "Yehudi Menuhin" },
                new Author { Name = "Yo-Yo Ma" },
                new Author { Name = "Zeca Pagodinho" }
            };

            new List<Post>
            {
                new Post { Title = "Lorem Ipsum", Tag = tags.Single(g => g.Name == "CMS"), Date = DateTime.Now, Author = authors.Single(a => a.Name == "Aaron Copland & London Symphony Orchestra"), Content = "Has autem provincias, quas Orontes ambiens amnis imosque pedes Cassii montis illius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis Armeniorum abstractas dicioni Romanae coniunxit.", Online= true },
                new Post { Title = "Ipsum Dolor", Tag = tags.Single(g => g.Name == "Graphisme"), Date = DateTime.Now, Author = authors.Single(a => a.Name == "Aaron Goldberg"), Content = "Has autem provincias, quas Orontes ambiens amnis imosque pedes Cassii montis illius celsi praetermeans funrato Tigrane regnis Armeniorum abstractas dicioni Romanae coniunxit.", Online= true },
                new Post { Title = "For Those About To Webdesign We Salute You", Tag = tags.Single(g => g.Name == "Webdesign"), Date = DateTime.Now, Author = authors.Single(a => a.Name == "AC/DC"), Content = "Has autem provincias, quas Orontes ambiens amnis imosque pedes Cassii montis illius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis Armenillius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis Armeniorum abstractas dicioni Romanae coniunxit.", Online= true },
                new Post { Title = "Let There Be Webdesign", Tag = tags.Single(g => g.Name == "Webdesign"), Date = DateTime.Now, Author = authors.Single(a => a.Name == "AC/DC"), Content = "Has autem provincias, quas Orontes ambiens amnis imosque pedes Cassii montis illius celsi praetermeans funditur in Parthenium <strong>mare, Gnaeus Pompeius superato</strong> Tigrane regnis Armeniorum abstractas dicioni Romanillius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis Armenae coniunxit.", Online= true },
                new Post { Title = "Balls to the Wall", Tag = tags.Single(g => g.Name == "Webdesign"), Date = DateTime.Now, Author = authors.Single(a => a.Name == "Accept"), Content = "Has autem provincias, quas Orontes ambiens amnis imosque pedes Cassii montis illius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis Armeniorum abstractas dicioni Romanae coniunxit.", Online= true },
                new Post { Title = "Restless and Wild", Tag = tags.Single(g => g.Name == "Webdesign"), Date = DateTime.Now, Author = authors.Single(a => a.Name == "Accept"), Content = "Has autem provincias, quas Orontes ambiens amnis imosque pedes Cassii montis illius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis Armeniorum abstractas dicioni Romanae coniunxit.", Online= true },
                new Post { Title = "Va y James prend moi", Tag = tags.Single(g => g.Name == "CMS"), Date = DateTime.Now, Author = authors.Single(a => a.Name == "Adrian Leaper & Doreen de Feis"), Content = "Has autem provincias, quas Orontes ambiens amnis imosque pedes Cassii montis illius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis Armeniorum abillius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis Armenstractas dicioni Romanae coniunxit.", Online= true },
                new Post { Title = "Big Ones", Tag = tags.Single(g => g.Name == "Webdesign"), Date = DateTime.Now, Author = authors.Single(a => a.Name == "Aerosmith"), Content = "Has autem illius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis Armenillius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis Armenprovincias, quas Orontes ambiens amnis imosque pedes Cassii montis illius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis Armeniorum abstractas dicioni Romanae coniunxit." , Online= true},
                new Post { Title = "Quiet Songs", Tag = tags.Single(g => g.Name == "Graphisme"), Date = DateTime.Now, Author = authors.Single(a => a.Name == "Aisha Duo"), Content = "Has autem provincias, quas Orontes ambiens amnis imosque pedes Cassii montis illius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis Armeniorum abstractas dicioni Romanae coniunxit.", Online= true },
                
            }.ForEach(a => context.Posts.Add(a));


            new List<Page>
            {
                new Page { Title = "Page 1", Date = DateTime.Now, Author = authors.Single(a => a.Name == "Aaron Copland & London Symphony Orchestra"), Content = "Has <strong>autem provincias, quas Orontes ambiens amnis<strong><div class=\"section\">imosque pedes Cassii montis illius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis</div><div class=\"section\">imosque pedes Cassii montis illius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis</div><div class=\"section\">imosque pedes Cassii montis illius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis</div> Armeniorum abstractas dicioni Romanae coniunxit.", Online= true },
                new Page { Title = "Page 2", Date = DateTime.Now, Author = authors.Single(a => a.Name == "Aaron Goldberg"), Content = "Has autem provincias, quas Orontes ambiens amnis imosque pedes Cassii montis illius celsi praetermeans funrato Tigrane regnis Armeniorum abstractas dicioni Romanae coniunxit.<div class=\"section\">imosque pedes Cassii montis illius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis</div><div class=\"section\">imosque pedes Cassii montis illius celsi praetermeans funditur in Parthenium mare, Gnaeus Pompeius superato Tigrane regnis</div>", Online= true }, 
            }.ForEach(a => context.Pages.Add(a));

        }

        
    }
}