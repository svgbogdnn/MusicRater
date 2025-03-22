//svg does precious
using System;                          // Аналог <iostream> для работы с консолью и основными функциями
using System.Collections.Generic;       // Аналог <vector>, <list>, <map>, <set>, <unordered_map>, <unordered_set>, <stack>, <queue>
using System.Text;                      // Аналог <string>, <cstring> (для работы со строками и StringBuilder)
using System.Linq;                      // Аналог <algorithm> (для работы с LINQ, сортировок, поиска и т.д.)
using System.IO;                        // Аналог <cstdio>, <fstream> (работа с файлами)
using System.Globalization;             // Аналог <iomanip> (для форматирования)
using System.Collections;               // Работа с различными коллекциями (например, ArrayList)
using System.Threading;                 // Потоки и многопоточность
using System.Runtime.Serialization;     // Аналог <stdexcept> (работа с исключениями)
using System.Reflection;                // Аналог <typeinfo> (информация о типах, рефлексия)
using System.Diagnostics;               // Аналог <utility>, <std::pair> (вспомогательные функции и классы)
using System.ComponentModel;            // Дополнительные утилиты и атрибуты
using System.Numerics;                  // Работа с большими числами и математическими операциями
using System.Globalization;
using System.Diagnostics;
using System.Net;
using System.Numerics;
// Для работы с потоками данных:
using System.Threading.Tasks;           // Асинхронные задачи

// Для работы с датами и временем:
using System.Timers;                    // Для работы с таймерами и временем
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO; //important
using System.Globalization;
using System.Collections;
using System.Threading;
using System.Runtime.Serialization;
using System.Reflection;
using System.Diagnostics;
using System.ComponentModel;
using System.Numerics;
using System.Globalization;
using System.Diagnostics;
using System.Net;
using System.Numerics;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Web;
using System.Media;
using System.Drawing;
using System.Configuration;
using System.Timers;
using System.Runtime.Remoting;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Runtime;
using System.Windows;
using System.Windows.Input;
using System.Security.Principal;
using System.Security.Permissions;
using System.Resources;
using Npgsql; // Для работы с PostgreSQL

/*
Izzspot - 19 years
Boogie B - 20 years
SJ - 21 years
Bandokay - life sentence

Youngest in the charge 
OFB, we don't window shop
Bro caught him an opp and tried turn him off (Bow, bow)
In this X3, man's swervin' off (Skrr, skrr)
Free Boogie Bando, he got birded off (Free my bro, free my bro)
Whenever we get a burner loss
We just cop a next one and go burst it off (Ay)
Lil bro's tellin' me he got his earnings wrong
We just took him OT, now his trapline's gone (Ring, ring)
Hashtag 
Bro backed this ting and just started squeezin' (Clarted)
When it broad day, it was freezin'
Hashtag fuckery, hashtag screamin'
One on the hand ting woi, left man lеanin', leanin' (Fucker)
Show us cause it's good to feel it
Shortiе's cooze and she must be dreamin'
*/
/* ¡Adelante Barcelona, adelante Cataluña! Visca el Barça! Visca Catalunya!
   ¡Al diablo con todos los demás, porque lo más importante en la vida es el fútbol!
*/
//-------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------

public class DatabaseChecker
{//check 
    private string connectionString;

    // ALBUM Validator
    public class AlbumValidator
    {
        public bool ValidateAlbumTitle(string albumTitle)
        {
            return !string.IsNullOrEmpty(albumTitle);
        }

        public bool ValidateTracksNum(decimal tracksNum)
        {
            return tracksNum > 0;
        }

        public bool ValidateReleaseDate(string releaseDate)
        {
            return !string.IsNullOrEmpty(releaseDate);
        }

        public bool ValidateLikesPercent(decimal likesPercent)
        {
            return likesPercent >= 0 && likesPercent <= 100;
        }

        public bool ValidateBestSongs(string bestSongs)
        {
            return !string.IsNullOrEmpty(bestSongs);
        }

        public bool ValidateViewsGenius(decimal viewsGenius)
        {
            return viewsGenius >= 0;
        }

        public bool ValidateStyles(string styles)
        {
            return !string.IsNullOrEmpty(styles);
        }

        public bool ValidateWannaRelisten(decimal wannaRelisten)
        {
            return wannaRelisten >= 0 && wannaRelisten <= 10;
        }

        public bool ValidateOverall(decimal overall)
        {
            return overall >= 0 && overall <= 10;
        }

        public bool ValidateCountry(string country)
        {
            return !string.IsNullOrEmpty(country);
        }

    }

    // ARTIST Validator
    public class ArtistValidator
    {
        public bool ValidateArtistName(string artist)
        {
            return !string.IsNullOrWhiteSpace(artist);
        }

        public bool ValidateNickname(string nickname)
        {
            return !string.IsNullOrWhiteSpace(nickname);
        }

        public bool ValidateStreamsPerMonth(decimal streamsPerMonth)
        {
            return streamsPerMonth >= 0;
        }

        public bool ValidateYearWasBorn(int yearWasBorn)
        {
            return yearWasBorn > 1900 && yearWasBorn <= DateTime.Now.Year;
        }

        public bool ValidatePotential(decimal potential)
        {
            return potential >= 0 && potential <= 10;
        }

        public bool ValidateFavouriteSongs(string favouriteSongs)
        {
            return !string.IsNullOrWhiteSpace(favouriteSongs);
        }

        public bool ValidateBestAlbum(string bestAlbum)
        {
            return !string.IsNullOrWhiteSpace(bestAlbum);
        }

        public bool ValidateVibe(decimal vibe)
        {
            return vibe >= 0 && vibe <= 10;
        }

        public bool ValidateAnnoyance(decimal annoyance)
        {
            return annoyance >= 0 && annoyance <= 10;
        }

        public bool ValidateOverall(decimal overall)
        {
            return overall >= 0 && overall <= 10;
        }

        public bool ValidateCountry(string country)
        {
            return !string.IsNullOrWhiteSpace(country);
        }

    }

    // SONG Validator
    public class SongValidator
    {
        public bool ValidateTitle(string title)
        {
            return !string.IsNullOrEmpty(title);
        }

        public bool ValidateArtist(string artist)
        {
            return !string.IsNullOrEmpty(artist);
        }

        public bool ValidateStreams(decimal streams)
        {
            return streams >= 0;
        }

        public bool ValidateVibe(decimal vibe)
        {
            return vibe >= 0 && vibe <= 10;
        }

        public bool ValidateBeat(decimal beat)
        {
            return beat >= 0 && beat <= 10;
        }

        public bool ValidateFlow(decimal flow)
        {
            return flow >= 0 && flow <= 10;
        }

        public bool ValidateReListening(decimal reListening)
        {
            return reListening >= 0 && reListening <= 10;
        }

        public bool ValidateEnergy(decimal energy)
        {
            return energy >= 0 && energy <= 10;
        }

        public bool ValidateOverall(decimal overall)
        {
            return overall >= 0 && overall <= 10;
        }

        public bool ValidateAlbum(string album)
        {
            return !string.IsNullOrEmpty(album);
        }

        public bool ValidateDate(string date)
        {
            return !string.IsNullOrEmpty(date); // Более точная проверка может быть добавлена для формата даты
        }

        public bool ValidateCountry(string country)
        {
            return !string.IsNullOrEmpty(country);
        }

    }
    public DatabaseChecker(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public static void Main(string[] args)
    {
        string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=musicspoti";
        DatabaseChecker checker = new DatabaseChecker(connectionString);

        Console.WriteLine("Starting validation for albums...");
        checker.ValidateAlbums();
        Console.WriteLine("Albums validation complete.");

        Console.WriteLine("Starting validation for artists...");
        checker.ValidateArtists();
        Console.WriteLine("Artists validation complete.");

        Console.WriteLine("Starting validation for songs...");
        checker.ValidateSongs();
        Console.WriteLine("Songs validation complete.");

    }

    // Validate Albums
    public void ValidateAlbums()
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM albums";
            using (var command = new NpgsqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                var validator = new AlbumValidator();

                while (reader.Read())
                {
                    string albumTitle = reader.GetString(reader.GetOrdinal("album_title"));
                    decimal tracksNum = reader.IsDBNull(reader.GetOrdinal("tracks_num"))
                                        ? 0
                                        : reader.GetDecimal(reader.GetOrdinal("tracks_num"));
                    string releaseDate = reader.GetString(reader.GetOrdinal("release_date"));
                    decimal likesPercent = reader.IsDBNull(reader.GetOrdinal("likes_percent"))
                                           ? 0
                                           : reader.GetDecimal(reader.GetOrdinal("likes_percent"));
                    string bestSongs = reader.GetString(reader.GetOrdinal("best_songs"));
                    decimal viewsGenius = reader.IsDBNull(reader.GetOrdinal("views_genius"))
                                          ? 0
                                          : reader.GetDecimal(reader.GetOrdinal("views_genius"));
                    string styles = reader.GetString(reader.GetOrdinal("styles"));
                    decimal wannaRelisten = reader.IsDBNull(reader.GetOrdinal("wanna_relisten"))
                                            ? 0
                                            : reader.GetDecimal(reader.GetOrdinal("wanna_relisten"));
                    decimal overall = reader.IsDBNull(reader.GetOrdinal("overall"))
                                      ? 0
                                      : reader.GetDecimal(reader.GetOrdinal("overall"));
                    string country = reader.GetString(reader.GetOrdinal("country"));

                    if (!validator.ValidateAlbumTitle(albumTitle))
                        Console.WriteLine($"Invalid album title: {albumTitle}");
                    if (!validator.ValidateTracksNum(tracksNum))
                        Console.WriteLine($"Invalid tracks number: {tracksNum}");
                    if (!validator.ValidateReleaseDate(releaseDate))
                        Console.WriteLine($"Invalid release date: {releaseDate}");
                    if (!validator.ValidateLikesPercent(likesPercent))
                        Console.WriteLine($"Invalid likes percent: {likesPercent}");
                    if (!validator.ValidateBestSongs(bestSongs))
                        Console.WriteLine($"Invalid best songs: {bestSongs}");
                    if (!validator.ValidateViewsGenius(viewsGenius))
                        Console.WriteLine($"Invalid views on Genius: {viewsGenius}");
                    if (!validator.ValidateStyles(styles))
                        Console.WriteLine($"Invalid styles: {styles}");
                    if (!validator.ValidateWannaRelisten(wannaRelisten))
                        Console.WriteLine($"Invalid wanna relisten score: {wannaRelisten}");
                    if (!validator.ValidateOverall(overall))
                        Console.WriteLine($"Invalid overall score: {overall}");
                    if (!validator.ValidateCountry(country))
                        Console.WriteLine($"Invalid country: {country}");
                }
            }
        }
    }


    // Validate Artists
    public void ValidateArtists()
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM artists";
            using (var command = new NpgsqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                var validator = new ArtistValidator();

                while (reader.Read())
                {
                    // Чтение данных с учетом возможных NULL и соответствия типов
                    string artist = reader.IsDBNull(reader.GetOrdinal("artist")) ? string.Empty : reader.GetString(reader.GetOrdinal("artist"));
                    string nickname = reader.IsDBNull(reader.GetOrdinal("nickname")) ? string.Empty : reader.GetString(reader.GetOrdinal("nickname"));
                    decimal streamsPerMonth = reader.IsDBNull(reader.GetOrdinal("streams_per_month")) ? 0 : reader.GetDecimal(reader.GetOrdinal("streams_per_month"));
                    int yearWasBorn = reader.IsDBNull(reader.GetOrdinal("year_was_born")) ? 0 : reader.GetInt32(reader.GetOrdinal("year_was_born"));
                    decimal potential = reader.IsDBNull(reader.GetOrdinal("potential")) ? 0 : reader.GetDecimal(reader.GetOrdinal("potential"));
                    string favouriteSongs = reader.IsDBNull(reader.GetOrdinal("favourite_songs")) ? string.Empty : reader.GetString(reader.GetOrdinal("favourite_songs"));
                    string bestAlbum = reader.IsDBNull(reader.GetOrdinal("best_album")) ? string.Empty : reader.GetString(reader.GetOrdinal("best_album"));
                    decimal vibe = reader.IsDBNull(reader.GetOrdinal("vibe")) ? 0 : reader.GetDecimal(reader.GetOrdinal("vibe"));
                    decimal annoyance = reader.IsDBNull(reader.GetOrdinal("annoyance")) ? 0 : reader.GetDecimal(reader.GetOrdinal("annoyance"));
                    decimal overall = reader.IsDBNull(reader.GetOrdinal("overall")) ? 0 : reader.GetDecimal(reader.GetOrdinal("overall"));
                    string country = reader.IsDBNull(reader.GetOrdinal("country")) ? string.Empty : reader.GetString(reader.GetOrdinal("country"));

                    // Валидация данных
                    if (!validator.ValidateArtistName(artist))
                        Console.WriteLine($"Invalid artist name: {artist}");
                    if (!validator.ValidateNickname(nickname))
                        Console.WriteLine($"Invalid nickname: {nickname}");
                    if (!validator.ValidateStreamsPerMonth(streamsPerMonth))
                        Console.WriteLine($"Invalid streams per month: {streamsPerMonth}");
                    if (!validator.ValidateYearWasBorn(yearWasBorn))
                        Console.WriteLine($"Invalid year born: {yearWasBorn}");
                    if (!validator.ValidatePotential(potential))
                        Console.WriteLine($"Invalid potential score: {potential}");
                    if (!validator.ValidateFavouriteSongs(favouriteSongs))
                        Console.WriteLine($"Invalid favourite songs: {favouriteSongs}");
                    if (!validator.ValidateBestAlbum(bestAlbum))
                        Console.WriteLine($"Invalid best album: {bestAlbum}");
                    if (!validator.ValidateVibe(vibe))
                        Console.WriteLine($"Invalid vibe score: {vibe}");
                    if (!validator.ValidateAnnoyance(annoyance))
                        Console.WriteLine($"Invalid annoyance score: {annoyance}");
                    if (!validator.ValidateOverall(overall))
                        Console.WriteLine($"Invalid overall score: {overall}");
                    if (!validator.ValidateCountry(country))
                        Console.WriteLine($"Invalid country: {country}");
                }
            }
        }
    }

    // Validate songs 
    public void ValidateSongs()
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM songs";
            using (var command = new NpgsqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                var validator = new SongValidator();

                while (reader.Read())
                {
                    // Чтение данных с проверкой на NULL и приведением типов
                    string title = reader.IsDBNull(reader.GetOrdinal("title")) ? string.Empty : reader.GetString(reader.GetOrdinal("title"));
                    string artist = reader.IsDBNull(reader.GetOrdinal("artist")) ? string.Empty : reader.GetString(reader.GetOrdinal("artist"));
                    decimal streams = reader.IsDBNull(reader.GetOrdinal("streams")) ? 0 : reader.GetDecimal(reader.GetOrdinal("streams"));
                    decimal vibe = reader.IsDBNull(reader.GetOrdinal("vibe")) ? 0 : reader.GetDecimal(reader.GetOrdinal("vibe"));
                    decimal beat = reader.IsDBNull(reader.GetOrdinal("beat")) ? 0 : reader.GetDecimal(reader.GetOrdinal("beat"));
                    decimal flow = reader.IsDBNull(reader.GetOrdinal("flow")) ? 0 : reader.GetDecimal(reader.GetOrdinal("flow"));
                    decimal reListening = reader.IsDBNull(reader.GetOrdinal("re_listening")) ? 0 : reader.GetDecimal(reader.GetOrdinal("re_listening"));
                    decimal energy = reader.IsDBNull(reader.GetOrdinal("energy")) ? 0 : reader.GetDecimal(reader.GetOrdinal("energy"));
                    decimal overall = reader.IsDBNull(reader.GetOrdinal("overall")) ? 0 : reader.GetDecimal(reader.GetOrdinal("overall"));
                    string album = reader.IsDBNull(reader.GetOrdinal("album")) ? string.Empty : reader.GetString(reader.GetOrdinal("album"));
                    string date = reader.IsDBNull(reader.GetOrdinal("date")) ? string.Empty : reader.GetString(reader.GetOrdinal("date"));
                    string country = reader.IsDBNull(reader.GetOrdinal("country")) ? string.Empty : reader.GetString(reader.GetOrdinal("country"));

                    // Валидация данных
                    if (!validator.ValidateTitle(title))
                        Console.WriteLine($"Invalid song title: {title}");
                    if (!validator.ValidateArtist(artist))
                        Console.WriteLine($"Invalid artist: {artist}");
                    if (!validator.ValidateStreams(streams))
                        Console.WriteLine($"Invalid streams: {streams}");
                    if (!validator.ValidateVibe(vibe))
                        Console.WriteLine($"Invalid vibe: {vibe}");
                    if (!validator.ValidateBeat(beat))
                        Console.WriteLine($"Invalid beat: {beat}");
                    if (!validator.ValidateFlow(flow))
                        Console.WriteLine($"Invalid flow: {flow}");
                    if (!validator.ValidateReListening(reListening))
                        Console.WriteLine($"Invalid re-listening: {reListening}");
                    if (!validator.ValidateEnergy(energy))
                        Console.WriteLine($"Invalid energy: {energy}");
                    if (!validator.ValidateOverall(overall))
                        Console.WriteLine($"Invalid overall score: {overall}");
                    if (!validator.ValidateAlbum(album))
                        Console.WriteLine($"Invalid album: {album}");
                    if (!validator.ValidateDate(date))
                        Console.WriteLine($"Invalid date: {date}");
                    if (!validator.ValidateCountry(country))
                        Console.WriteLine($"Invalid country: {country}");
                }
            }
        }
    }


    //
    //
    //
    //
    //

    // Класс форматирования строк
    public class StringFormatter
    {
        public string FormatArtistName(string artistName)
        {
            if (string.IsNullOrWhiteSpace(artistName))
                return artistName;

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(artistName.ToLower());
        }

        public string FormatDate(DateTime date, string format = "dd.MM.yyyy")
        {
            return date.ToString(format);
        }

        public string FormatSongTitle(string songTitle)
        {
            if (string.IsNullOrWhiteSpace(songTitle))
                return songTitle;

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(songTitle.Trim().ToLower());
        }

        public string FormatCountryCode(string countryCode)
        {
            return countryCode.ToUpper();
        }

        public string TruncateText(string text, int maxLength)
        {
            if (text.Length <= maxLength)
                return text;

            return text.Substring(0, maxLength) + "...";
        }

        public string CapitalizeEachWord(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(text.ToLower());
        }



        public string ReplaceSpacesWithHyphens(string input)
        {
            return input.Replace(" ", "-").ToLower();
        }
    }


    public void ValidateAlbums(StringFormatter formatter)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM albums";
            using (var command = new NpgsqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string albumTitle = reader.GetString(reader.GetOrdinal("album_title"));
                    string formattedTitle = formatter.FormatSongTitle(albumTitle);
                    Console.WriteLine($"Formatted album title: {formattedTitle}");

                }
            }
        }
    }

    public void ValidateArtists(StringFormatter formatter)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM artists";
            using (var command = new NpgsqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string artistName = reader.GetString(reader.GetOrdinal("artist"));
                    string formattedArtist = formatter.FormatArtistName(artistName);
                    Console.WriteLine($"Formatted artist name: {formattedArtist}");

                }
            }
        }
    }
    public void ValidateSong(StringFormatter formatter)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM songs";
            using (var command = new NpgsqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string title = reader.GetString(reader.GetOrdinal("title"));
                    string artist = reader.GetString(reader.GetOrdinal("artist"));

                    // Форматируем название песни и имя исполнителя с помощью StringFormatter
                    string formattedTitle = formatter.FormatSongTitle(title);
                    string formattedArtist = formatter.FormatArtistName(artist);

                    Console.WriteLine($"Formatted song title: {formattedTitle}");
                    Console.WriteLine($"Formatted artist name: {formattedArtist}");


                }
            }
        }
    }

}
