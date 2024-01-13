// <copyright file="FileTypes.cs" company="Rocket Robin">
// Copyright (c) Rocket Robin. All rights reserved.
// Licensed under the Apache v2 license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Myrmec.net8
{
  /// <summary>
  /// Common file types for populate a new sniffer instance.
  /// </summary>

  [Obsolete("please use populate the file types only you need.")]
    public class FileTypes
    {
        static FileTypes()
        {
            
            Unfrequent =
            [
                new("bin", "53 50 30 31"),
                new("bac", "42 41 43 4B 4D 49 4B 45 44 49 53 4B"),
                new("bz2", "42 5A 68"),
                new("tif tiff", "49 49 2A 00"),
                new("tif tiff", "4D 4D 00 2A"),
                new("cr2", "49 49 2A 00 10 00 00 00 43 52"),
                new("cin", "80 2A 5F D7"),
                new("exr", "76 2F 31 01"),
                new("dpx", "53 44 50 58"),
                new("dpx", "58 50 44 53"),
                new("bpg", "42 50 47 FB"),
                new("lz", "4C 5A 49 50"),
                new("ps", "25 21 50 53"),
                new("fits", "3D 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 54"),
                new("doc xls ppt msg", "D0 CF 11 E0 A1 B1 1A E1"),
                new("dex", "64 65 78 0A 30 33 35 00"),
                new("vmdk", "4B 44 4D"),
                new("crx", "43 72 32 34"),
                new("cwk", "05 07 00 00 42 4F 42 4F 05 07 00 00 00 00 00 00 00 00 00 00 00 01"),
                new("fh8", "41 47 44 33"),
                new("cwk", "06 07 E1 00 42 4F 42 4F 06 07 E1 00 00 00 00 00 00 00 00 00 00 01"),
                new("toast", "45 52 02 00 00 00"),
                new("toast", "8B 45 52 02 00 00 00"),
                new("xar", "78 61 72 21"),
                new("dat", "50 4D 4F 43 43 4D 4F 43"),
                new("nes", "4E 45 53 1A"),
                new("tox", "74 6F 78 33"),
                new("MLV", "4D 4C 56 49"),
                new("lz4", "04 22 4D 18"),
                new("cab", "4D 53 43 46"),
                new("flif", "46 4C 49 46"),
                new("stg", "4D 49 4C 20"),
                new("der", "30 82"),
                new("wasm", "00 61 73 6d"),
                new("lep", "cf 84 01"),
                new("rtf", "7B 5C 72 74 66 31"),
                new("m2p vob", "00 00 01 BA"),
                new("zlib", "78 01"),
                new("zlib", "78 9c"),
                new("zlib", "78 da"),
                new("lzfse", "62 76 78 32"),
                new("orc", "4F 52 43"),
                new("avro", "4F 62 6A 01"),
                new("rc", "53 45 51 36"),
                new("tbi", "00 00 00 00 14 00 00 00"),
                new("dat", "00 00 00 00 62 31 05 00 09 00 00 00 00 20 00 00 00 09 00 00 00 00 00 00", 8, "Bitcoin Core wallet.dat file"),
                new("jp2", "00 00 00 0C 6A 50 20 20 0D 0A", "Various JPEG-2000 image file formats"),
                new("ttf", "00 01 00 00 00"),
                new("mdf", "00 FF FF FF FF FF FF FF FF FF FF 00 00 02 00 01"),

                // Complex file type.
                new("pdb", "00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00", 11),
                new("3gp 3g2", "66 74 79 70 33 67", 4),
                new("iso", "43 44 30 30 31", 32769),
                new("iso", "43 44 30 30 31", 34817),
                new("iso", "43 44 30 30 31", 36865),
            ];
            Common =
            [
                new("asf wma wmv", "30 26 B2 75 8E 66 CF 11 A6 D9 00 AA 00 62 CE 6C"),
                new("ogg oga ogv", "4F 67 67 53"),
                new("psd", "38 42 50 53"),
                new("mp3", "FF FB"),
                new("mp3", "49 44 33"),
                new("bmp dib", "42 4D"),
                new("jpg,jpeg", "ff,d8,ff,db"),
                new("png", "89,50,4e,47,0d,0a,1a,0a"),
                new("zip,jar,odt,ods,odp,docx,xlsx,pptx,vsdx,apk,aar", "50,4b,03,04"),
                new("zip,jar,odt,ods,odp,docx,xlsx,pptx,vsdx,apk,aar", "50,4b,07,08"),
                new("zip,jar,odt,ods,odp,docx,xlsx,pptx,vsdx,apk,aar", "50,4b,05,06"),
                new("rar", "52,61,72,21,1a,07,00"),
                new("rar", "52,61,72,21,1a,07,01,00"),
                new("class", "CA FE BA BE"),
                new("pdf", "25 50 44 46"),
                new("rpm", "ed ab ee db"),
                new("flac", "66 4C 61 43"),
                new("mid midi", "4D 54 68 64"),
                new("ico", "00 00 01 00"),
                new("z,tar.z", "1F 9D"),
                new("z,tar.z", "1F A0"),
                new("gif", "47 49 46 38 37 61"),
                new("dmg", "78 01 73 0D 62 62 60"),
                new("gif", "47 49 46 38 39 61"),
                new("exe", "4D 5A"),
                new("tar", "75 73 74 61 72", 257),
                new("mkv mka mks mk3d webm", "1A 45 DF A3"),
                new("gz tar.gz", "1F 8B"),
                new("xz tar.xz", "FD 37 7A 58 5A 00 00"),
                new("7z", "37 7A BC AF 27 1C"),
                new("mpg mpeg", "00 00 01 BA"),
                new("mpg mpeg", "00 00 01 B3"),
                new("woff", "77 4F 46 46"),
                new("woff2", "77 4F 46 32"),
                new("XML", "3c 3f 78 6d 6c 20"),
                new("swf", "43 57 53"),
                new("swf", "46 57 53"),
                new("deb", "21 3C 61 72 63 68 3E"),

                // complext
                new("jpg,jpeg","FF D8 FF E0 ?? ?? 4A 46 49 46 00 01"),
                new("jpg,jpeg","FF D8 FF E1 ?? ?? 45 78 69 66 00 00"),
            ];
        }

        /// <summary>
        /// Gets CommonFileTypes.
        /// Replace this with <see cref="Common"/>
        /// </summary>
        [Obsolete("please use populate the file types only you need.")]
        public static List<Record> CommonFileTypes { get => Common; }

        /// <summary>
        /// Gets Common It contains the format of the file we often see.
        /// </summary>
        [Obsolete("please use populate the file types only you need.")]
        public static List<Record> Common { get; set; }


        /// <summary>
        /// It contains unfrequent file formats.
        /// </summary>
        [Obsolete("please use populate the file types only you need.")]
        public static List<Record> Unfrequent { get; set; }
    }
}