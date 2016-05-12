﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaGit
{
    public partial class NumerosRomanos : Form
    {
        string[] numRomanos = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII", "XIII", "XIV", "XV", "XVI", "XVII", "XVIII", "XIX", "XX", "XXI", "XXII",
"XXIII", "XXIV", "XXV", "XXVI", "XXVII", "XXVIII", "XXIX", "XXX", "XXXI", "XXXII", "XXXIII", "XXXIV", "XXXV", "XXXVI", "XXXVII", "XXXVIII",
"XXXIX", "XL", "XLI", "XLII", "XLIII", "XLIV", "XLV", "XLVI", "XLVII", "XLVIII", "XLIX", "L", "LI", "LII", "LIII", "LIV", "LV", "LVI", "LVII",
"LVIII", "LIX", "LX", "LXI", "LXII", "LXIII", "LXIV", "LXV", "LXVI", "LXVII", "LXVIII", "LXIX", "LXX", "LXXI", "LXXII", "LXXIII", "LXXIV", "LXXV",
"LXXVI", "LXXVII", "LXXVIII", "LXXIX", "LXXX", "LXXXI", "LXXXII", "LXXXIII", "LXXXIV", "LXXXV", "LXXXVI", "LXXXVII", "LXXXVIII", "LXXXIX",
"XC", "XCI", "XCII", "XCIII", "XCIV", "XCV", "XCVI", "XCVII", "XCVIII", "XCIX", "C", "CI", "CII", "CIII", "CIV", "CV", "CVI", "CVII", "CVIII", "CIX",
"CX", "CXI", "CXII", "CXIII", "CXIV", "CXV", "CXVI", "CXVII", "CXVIII", "CXIX", "CXX", "CXXI", "CXXII", "CXXIII", "CXXIV", "CXXV", "CXXVI", "CXXVII",
"CXXVIII", "CXXIX", "CXXX", "CXXXI", "CXXXII", "CXXXIII", "CXXXIV", "CXXXV", "CXXXVI", "CXXXVII", "CXXXVIII", "CXXXIX", "CXL", "CXLI", "CXLII",
"CXLIII", "CXLIV", "CXLV", "CXLVI", "CXLVII", "CXLVIII", "CXLIX", "CL", "CLI", "CLII", "CLIII", "CLIV", "CLV", "CLVI", "CLVII", "CLVIII", "CLIX",
"CLX", "CLXI", "CLXII", "CLXIII", "CLXIV", "CLXV", "CLXVI", "CLXVII", "CLXVIII", "CLXIX", "CLXX", "CLXXI", "CLXXII", "CLXXIII", "CLXXIV", "CLXXV",
"CLXXVI", "CLXXVII", "CLXXVIII", "CLXXIX", "CLXXX", "CLXXXI", "CLXXXII", "CLXXXIII", "CLXXXIV", "CLXXXV", "CLXXXVI", "CLXXXVII", "CLXXXVIII",
"CLXXXIX", "CXC", "CXCI", "CXCII", "CXCIII", "CXCIV", "CXCV", "CXCVI", "CXCVII", "CXCVIII", "CXCIX", "CC", "CCI", "CCII", "CCIII", "CCIV", "CCV",
"CCVI", "CCVII", "CCVIII", "CCIX", "CCX", "CCXI", "CCXII", "CCXIII", "CCXIV", "CCXV", "CCXVI", "CCXVII", "CCXVIII", "CCXIX", "CCXX", "CCXXI", "CCXXII",
"CCXXIII", "CCXXIV", "CCXXV", "CCXXVI", "CCXXVII", "CCXXVIII", "CCXXIX", "CCXXX", "CCXXXI", "CCXXXII", "CCXXXIII", "CCXXXIV", "CCXXXV", "CCXXXVI",
"CCXXXVII", "CCXXXVIII", "CCXXXIX", "CCXL", "CCXLI", "CCXLII", "CCXLIII", "CCXLIV", "CCXLV", "CCXLVI", "CCXLVII", "CCXLVIII", "CCXLIX", "CCL",
"CCLI", "CCLII", "CCLIII", "CCLIV", "CCLV", "CCLVI", "CCLVII", "CCLVIII", "CCLIX", "CCLX", "CCLXI", "CCLXII", "CCLXIII", "CCLXIV", "CCLXV", "CCLXVI",
"CCLXVII", "CCLXVIII", "CCLXIX", "CCLXX", "CCLXXI", "CCLXXII", "CCLXXIII", "CCLXXIV", "CCLXXV", "CCLXXVI", "CCLXXVII", "CCLXXVIII", "CCLXXIX", "CCLXXX",
"CCLXXXI", "CCLXXXII", "CCLXXXIII", "CCLXXXIV", "CCLXXXV", "CCLXXXVI", "CCLXXXVII", "CCLXXXVIII", "CCLXXXIX", "CCXC", "CCXCI", "CCXCII", "CCXCIII", "CCXCIV",
"CCXCV", "CCXCVI", "CCXCVII", "CCXCVIII", "CCXCIX", "CCC", "CCCI", "CCCII", "CCCIII", "CCCIV", "CCCV", "CCCVI", "CCCVII", "CCCVIII", "CCCIX", "CCCX", "CCCXI",
"CCCXII", "CCCXIII", "CCCXIV", "CCCXV", "CCCXVI", "CCCXVII", "CCCXVIII", "CCCXIX", "CCCXX", "CCCXXI", "CCCXXII", "CCCXXIII", "CCCXXIV", "CCCXXV",
"CCCXXVI", "CCCXXVII", "CCCXXVIII", "CCCXXIX", "CCCXXX", "CCCXXXI", "CCCXXXII", "CCCXXXIII", "CCCXXXIV", "CCCXXXV", "CCCXXXVI", "CCCXXXVII", "CCCXXXVIII", "CCCXXXIX",
"CCCXL", "CCCXLI", "CCCXLII", "CCCXLIII", "CCCXLIV", "CCCXLV", "CCCXLVI", "CCCXLVII", "CCCXLVIII", "CCCXLIX", "CCCL", "CCCLI", "CCCLII", "CCCLIII", "CCCLIV",
"CCCLV", "CCCLVI", "CCCLVII", "CCCLVIII", "CCCLIX", "CCCLX", "CCCLXI", "CCCLXII", "CCCLXIII", "CCCLXIV", "CCCLXV", "CCCLXVI", "CCCLXVII", "CCCLXVIII", "CCCLXIX",
"CCCLXX", "CCCLXXI", "CCCLXXII", "CCCLXXIII", "CCCLXXIV", "CCCLXXV", "CCCLXXVI", "CCCLXXVII", "CCCLXXVIII", "CCCLXXIX", "CCCLXXX", "CCCLXXXI", "CCCLXXXII",
"CCCLXXXIII", "CCCLXXXIV", "CCCLXXXV", "CCCLXXXVI", "CCCLXXXVII", "CCCLXXXVIII", "CCCLXXXIX", "CCCXC", "CCCXCI", "CCCXCII", "CCCXCIII", "CCCXCIV", "CCCXCV",
"CCCXCVI", "CCCXCVII", "CCCXCVIII", "CCCXCIX", "CD", "CDI", "CDII", "CDIII", "CDIV", "CDV", "CDVI", "CDVII", "CDVIII", "CDIX", "CDX", "CDXI", "CDXII",
"CDXIII", "CDXIV", "CDXV", "CDXVI", "CDXVII", "CDXVIII", "CDXIX", "CDXX", "CDXXI", "CDXXII", "CDXXIII", "CDXXIV", "CDXXV", "CDXXVI", "CDXXVII", "CDXXVIII",
"CDXXIX", "CDXXX", "CDXXXI", "CDXXXII", "CDXXXIII", "CDXXXIV", "CDXXXV", "CDXXXVI", "CDXXXVII", "CDXXXVIII", "CDXXXIX", "CDXL", "CDXLI", "CDXLII", "CDXLIII", "CDXLIV",
"CDXLV", "CDXLVI", "CDXLVII", "CDXLVIII", "CDXLIX", "CDL", "CDLI", "CDLII", "CDLIII", "CDLIV", "CDLV", "CDLVI", "CDLVII", "CDLVIII", "CDLIX", "CDLX", "CDLXI",
"CDLXII", "CDLXIII", "CDLXIV", "CDLXV", "CDLXVI", "CDLXVII", "CDLXVIII", "CDLXIX", "CDLXX", "CDLXXI", "CDLXXII", "CDLXXIII", "CDLXXIV", "CDLXXV", "CDLXXVI",
"CDLXXVII", "CDLXXVIII", "CDLXXIX", "CDLXXX", "CDLXXXI", "CDLXXXII", "CDLXXXIII", "CDLXXXIV", "CDLXXXV", "CDLXXXVI", "CDLXXXVII", "CDLXXXVIII", "CDLXXXIX",
"CDXC", "CDXCI", "CDXCII", "CDXCIII", "CDXCIV", "CDXCV", "CDXCVI", "CDXCVII", "CDXCVIII", "CDXCIX", "D", "DI", "DII", "DIII", "DIV", "DV", "DVI", "DVII", "DVIII",
"DIX", "DX", "DXI", "DXII", "DXIII", "DXIV", "DXV", "DXVI", "DXVII", "DXVIII", "DXIX", "DXX", "DXXI", "DXXII", "DXXIII", "DXXIV", "DXXV", "DXXVI", "DXXVII",
"DXXVIII", "DXXIX", "DXXX", "DXXXI", "DXXXII", "DXXXIII", "DXXXIV", "DXXXV", "DXXXVI", "DXXXVII", "DXXXVIII", "DXXXIX", "DXL", "DXLI", "DXLII", "DXLIII", "DXLIV",
"DXLV", "DXLVI", "DXLVII", "DXLVIII", "DXLIX", "DL", "DLI", "DLII", "DLIII", "DLIV", "DLV", "DLVI", "DLVII", "DLVIII", "DLIX", "DLX", "DLXI", "DLXII", "DLXIII",
"DLXIV", "DLXV", "DLXVI", "DLXVII", "DLXVIII", "DLXIX", "DLXX", "DLXXI", "DLXXII", "DLXXIII", "DLXXIV", "DLXXV", "DLXXVI", "DLXXVII", "DLXXVIII", "DLXXIX",
"DLXXX", "DLXXXI", "DLXXXII", "DLXXXIII", "DLXXXIV", "DLXXXV", "DLXXXVI", "DLXXXVII", "DLXXXVIII", "DLXXXIX", "DXC", "DXCI", "DXCII", "DXCIII", "DXCIV", "DXCV",
"DXCVI", "DXCVII", "DXCVIII", "DXCIX", "DC", "DCI", "DCII", "DCIII", "DCIV", "DCV", "DCVI", "DCVII", "DCVIII", "DCIX", "DCX", "DCXI", "DCXII", "DCXIII", "DCXIV", "DCXV",
"DCXVI", "DCXVII", "DCXVIII", "DCXIX", "DCXX", "DCXXI", "DCXXII", "DCXXIII", "DCXXIV", "DCXXV", "DCXXVI", "DCXXVII", "DCXXVIII", "DCXXIX", "DCXXX", "DCXXXI",
"DCXXXII", "DCXXXIII", "DCXXXIV", "DCXXXV", "DCXXXVI", "DCXXXVII", "DCXXXVIII", "DCXXXIX", "DCXL", "DCXLI", "DCXLII", "DCXLIII", "DCXLIV", "DCXLV", "DCXLVI",
"DCXLVII", "DCXLVIII", "DCXLIX", "DCL", "DCLI", "DCLII", "DCLIII", "DCLIV", "DCLV", "DCLVI", "DCLVII", "DCLVIII", "DCLIX", "DCLX", "DCLXI", "DCLXII", "DCLXIII",
"DCLXIV", "DCLXV", "DCLXVI", "DCLXVII", "DCLXVIII", "DCLXIX", "DCLXX", "DCLXXI", "DCLXXII", "DCLXXIII", "DCLXXIV", "DCLXXV", "DCLXXVI", "DCLXXVII", "DCLXXVIII",
"DCLXXIX", "DCLXXX", "DCLXXXI", "DCLXXXII", "DCLXXXIII", "DCLXXXIV", "DCLXXXV", "DCLXXXVI", "DCLXXXVII", "DCLXXXVIII", "DCLXXXIX", "DCXC", "DCXCI", "DCXCII",
"DCXCIII", "DCXCIV", "DCXCV", "DCXCVI", "DCXCVII", "DCXCVIII", "DCXCIX", "DCC", "DCCI", "DCCII", "DCCIII", "DCCIV", "DCCV", "DCCVI", "DCCVII", "DCCVIII",
"DCCIX", "DCCX", "DCCXI", "DCCXII", "DCCXIII", "DCCXIV", "DCCXV", "DCCXVI", "DCCXVII", "DCCXVIII", "DCCXIX", "DCCXX", "DCCXXI", "DCCXXII", "DCCXXIII",
"DCCXXIV", "DCCXXV", "DCCXXVI", "DCCXXVII", "DCCXXVIII", "DCCXXIX", "DCCXXX", "DCCXXXI", "DCCXXXII", "DCCXXXIII", "DCCXXXIV", "DCCXXXV", "DCCXXXVI", "DCCXXXVII", "DCCXXXVIII",
"DCCXXXIX", "DCCXL", "DCCXLI", "DCCXLII", "DCCXLIII", "DCCXLIV", "DCCXLV", "DCCXLVI", "DCCXLVII", "DCCXLVIII", "DCCXLIX", "DCCL", "DCCLI", "DCCLII", "DCCLIII",
"DCCLIV", "DCCLV", "DCCLVI", "DCCLVII", "DCCLVIII", "DCCLIX", "DCCLX", "DCCLXI", "DCCLXII", "DCCLXIII", "DCCLXIV", "DCCLXV", "DCCLXVI", "DCCLXVII", "DCCLXVIII", "DCCLXIX",
"DCCLXX", "DCCLXXI", "DCCLXXII", "DCCLXXIII", "DCCLXXIV", "DCCLXXV", "DCCLXXVI", "DCCLXXVII", "DCCLXXVIII", "DCCLXXIX", "DCCLXXX", "DCCLXXXI", "DCCLXXXII",
"DCCLXXXIII", "DCCLXXXIV", "DCCLXXXV", "DCCLXXXVI", "DCCLXXXVII", "DCCLXXXVIII", "DCCLXXXIX", "DCCXC", "DCCXCI", "DCCXCII", "DCCXCIII", "DCCXCIV", "DCCXCV", "DCCXCVI",
"DCCXCVII", "DCCXCVIII", "DCCXCIX", "DCCC", "DCCCI", "DCCCII", "DCCCIII", "DCCCIV", "DCCCV", "DCCCVI", "DCCCVII", "DCCCVIII", "DCCCIX", "DCCCX", "DCCCXI",
"DCCCXII", "DCCCXIII", "DCCCXIV", "DCCCXV", "DCCCXVI", "DCCCXVII", "DCCCXVIII", "DCCCXIX", "DCCCXX", "DCCCXXI", "DCCCXXII", "DCCCXXIII", "DCCCXXIV", "DCCCXXV", "DCCCXXVI",
"DCCCXXVII", "DCCCXXVIII", "DCCCXXIX", "DCCCXXX", "DCCCXXXI", "DCCCXXXII", "DCCCXXXIII", "DCCCXXXIV", "DCCCXXXV", "DCCCXXXVI", "DCCCXXXVII", "DCCCXXXVIII",
"DCCCXXXIX", "DCCCXL", "DCCCXLI", "DCCCXLII", "DCCCXLIII", "DCCCXLIV", "DCCCXLV", "DCCCXLVI", "DCCCXLVII", "DCCCXLVIII", "DCCCXLIX", "DCCCL", "DCCCLI",
"DCCCLII", "DCCCLIII", "DCCCLIV", "DCCCLV", "DCCCLVI", "DCCCLVII", "DCCCLVIII", "DCCCLIX", "DCCCLX", "DCCCLXI", "DCCCLXII", "DCCCLXIII", "DCCCLXIV",
"DCCCLXV", "DCCCLXVI", "DCCCLXVII", "DCCCLXVIII", "DCCCLXIX", "DCCCLXX", "DCCCLXXI", "DCCCLXXII", "DCCCLXXIII", "DCCCLXXIV", "DCCCLXXV", "DCCCLXXVI", "DCCCLXXVII",
"DCCCLXXVIII", "DCCCLXXIX", "DCCCLXXX", "DCCCLXXXI", "DCCCLXXXII", "DCCCLXXXIII", "DCCCLXXXIV", "DCCCLXXXV", "DCCCLXXXVI", "DCCCLXXXVII", "DCCCLXXXVIII", "DCCCLXXXIX",
"DCCCXC", "DCCCXCI", "DCCCXCII", "DCCCXCIII", "DCCCXCIV", "DCCCXCV", "DCCCXCVI", "DCCCXCVII", "DCCCXCVIII", "DCCCXCIX", "CM", "CMI", "CMII", "CMIII", "CMIV", "CMV", "CMVI", "CMVII",
"CMVIII", "CMIX", "CMX", "CMXI", "CMXII", "CMXIII", "CMXIV", "CMXV", "CMXVI", "CMXVII", "CMXVIII", "CMXIX", "CMXX", "CMXXI", "CMXXII", "CMXXIII", "CMXXIV", "CMXXV", "CMXXVI", "CMXXVII",
"CMXXVIII", "CMXXIX", "CMXXX", "CMXXXI", "CMXXXII", "CMXXXIII", "CMXXXIV", "CMXXXV", "CMXXXVI", "CMXXXVII", "CMXXXVIII", "CMXXXIX", "CMXL", "CMXLI", "CMXLII", "CMXLIII", "CMXLIV", "CMXLV",
"CMXLVI", "CMXLVII", "CMXLVIII", "CMXLIX", "CML", "CMLI", "CMLII", "CMLIII", "CMLIV", "CMLV", "CMLVI", "CMLVII", "CMLVIII", "CMLIX", "CMLX", "CMLXI", "CMLXII", "CMLXIII", "CMLXIV", "CMLXV", "CMLXVI",
"CMLXVII", "CMLXVIII", "CMLXIX", "CMLXX", "CMLXXI", "CMLXXII", "CMLXXIII", "CMLXXIV", "CMLXXV", "CMLXXVI", "CMLXXVII", "CMLXXVIII", "CMLXXIX", "CMLXXX", "CMLXXXI", "CMLXXXII", "CMLXXXIII", "CMLXXXIV",
"CMLXXXV", "CMLXXXVI", "CMLXXXVII", "CMLXXXVIII", "CMLXXXIX", "CMXC", "CMXCI", "CMXCII", "CMXCIII", "CMXCIV", "CMXCV", "CMXCVI", "CMXCVII", "CMXCVIII", "CMXCIX", "M", "MI", "MII", "MIII", "MIV",
"MV", "MVI", "MVII", "MVIII", "MIX", "MX", "MXI", "MXII", "MXIII", "MXIV", "MXV", "MXVI", "MXVII", "MXVIII", "MXIX", "MXX", "MXXI", "MXXII", "MXXIII", "MXXIV", "MXXV", "MXXVI", "MXXVII", "MXXVIII",
"MXXIX", "MXXX", "MXXXI", "MXXXII", "MXXXIII", "MXXXIV", "MXXXV", "MXXXVI", "MXXXVII", "MXXXVIII", "MXXXIX", "MXL", "MXLI", "MXLII", "MXLIII", "MXLIV", "MXLV", "MXLVI", "MXLVII", "MXLVIII", "MXLIX",
"ML", "MLI", "MLII", "MLIII", "MLIV", "MLV", "MLVI", "MLVII", "MLVIII", "MLIX", "MLX", "MLXI", "MLXII", "MLXIII", "MLXIV", "MLXV", "MLXVI", "MLXVII", "MLXVIII", "MLXIX", "MLXX", "MLXXI", "MLXXII", "MLXXIII",
"MLXXIV", "MLXXV", "MLXXVI", "MLXXVII", "MLXXVIII", "MLXXIX", "MLXXX", "MLXXXI", "MLXXXII", "MLXXXIII", "MLXXXIV", "MLXXXV", "MLXXXVI", "MLXXXVII", "MLXXXVIII", "MLXXXIX", "MXC", "MXCI", "MXCII", "MXCIII",
"MXCIV", "MXCV", "MXCVI", "MXCVII", "MXCVIII", "MXCIX", "MC", "MCI", "MCII", "MCIII", "MCIV", "MCV", "MCVI", "MCVII", "MCVIII", "MCIX", "MCX", "MCXI", "MCXII", "MCXIII", "MCXIV", "MCXV", "MCXVI", "MCXVII", "MCXVIII",
"MCXIX", "MCXX", "MCXXI", "MCXXII", "MCXXIII", "MCXXIV", "MCXXV", "MCXXVI", "MCXXVII", "MCXXVIII", "MCXXIX", "MCXXX", "MCXXXI", "MCXXXII", "MCXXXIII", "MCXXXIV", "MCXXXV", "MCXXXVI", "MCXXXVII", "MCXXXVIII", "MCXXXIX",
"MCXL", "MCXLI", "MCXLII", "MCXLIII", "MCXLIV", "MCXLV", "MCXLVI", "MCXLVII", "MCXLVIII", "MCXLIX", "MCL", "MCLI", "MCLII", "MCLIII", "MCLIV", "MCLV", "MCLVI", "MCLVII", "MCLVIII", "MCLIX", "MCLX", "MCLXI", "MCLXII",
"MCLXIII", "MCLXIV", "MCLXV", "MCLXVI", "MCLXVII", "MCLXVIII", "MCLXIX", "MCLXX", "MCLXXI", "MCLXXII", "MCLXXIII", "MCLXXIV", "MCLXXV", "MCLXXVI", "MCLXXVII", "MCLXXVIII", "MCLXXIX", "MCLXXX", "MCLXXXI", "MCLXXXII", "MCLXXXIII",
"MCLXXXIV", "MCLXXXV", "MCLXXXVI", "MCLXXXVII", "MCLXXXVIII", "MCLXXXIX", "MCXC", "MCXCI", "MCXCII", "MCXCIII", "MCXCIV", "MCXCV", "MCXCVI", "MCXCVII", "MCXCVIII", "MCXCIX", "MCC", "MCCI", "MCCII", "MCCIII", "MCCIV",
"MCCV", "MCCVI", "MCCVII", "MCCVIII", "MCCIX", "MCCX", "MCCXI", "MCCXII", "MCCXIII", "MCCXIV", "MCCXV", "MCCXVI", "MCCXVII", "MCCXVIII", "MCCXIX", "MCCXX", "MCCXXI", "MCCXXII", "MCCXXIII", "MCCXXIV", "MCCXXV",
"MCCXXVI", "MCCXXVII", "MCCXXVIII", "MCCXXIX", "MCCXXX", "MCCXXXI", "MCCXXXII", "MCCXXXIII", "MCCXXXIV", "MCCXXXV", "MCCXXXVI", "MCCXXXVII", "MCCXXXVIII", "MCCXXXIX", "MCCXL", "MCCXLI", "MCCXLII", "MCCXLIII",
"MCCXLIV", "MCCXLV", "MCCXLVI", "MCCXLVII", "MCCXLVIII", "MCCXLIX", "MCCL", "MCCLI", "MCCLII", "MCCLIII", "MCCLIV", "MCCLV", "MCCLVI", "MCCLVII", "MCCLVIII", "MCCLIX", "MCCLX", "MCCLXI", "MCCLXII", "MCCLXIII",
"MCCLXIV", "MCCLXV", "MCCLXVI", "MCCLXVII", "MCCLXVIII", "MCCLXIX", "MCCLXX", "MCCLXXI", "MCCLXXII", "MCCLXXIII", "MCCLXXIV", "MCCLXXV", "MCCLXXVI", "MCCLXXVII", "MCCLXXVIII", "MCCLXXIX", "MCCLXXX",
"MCCLXXXI", "MCCLXXXII", "MCCLXXXIII", "MCCLXXXIV", "MCCLXXXV", "MCCLXXXVI", "MCCLXXXVII", "MCCLXXXVIII", "MCCLXXXIX", "MCCXC", "MCCXCI", "MCCXCII", "MCCXCIII", "MCCXCIV", "MCCXCV", "MCCXCVI",
"MCCXCVII", "MCCXCVIII", "MCCXCIX", "MCCC", "MCCCI", "MCCCII", "MCCCIII", "MCCCIV", "MCCCV", "MCCCVI", "MCCCVII", "MCCCVIII", "MCCCIX", "MCCCX", "MCCCXI", "MCCCXII", "MCCCXIII", "MCCCXIV", "MCCCXV",
"MCCCXVI", "MCCCXVII", "MCCCXVIII", "MCCCXIX", "MCCCXX", "MCCCXXI", "MCCCXXII", "MCCCXXIII", "MCCCXXIV", "MCCCXXV", "MCCCXXVI", "MCCCXXVII", "MCCCXXVIII", "MCCCXXIX", "MCCCXXX", "MCCCXXXI", "MCCCXXXII",
"MCCCXXXIII", "MCCCXXXIV", "MCCCXXXV", "MCCCXXXVI", "MCCCXXXVII", "MCCCXXXVIII", "MCCCXXXIX", "MCCCXL", "MCCCXLI", "MCCCXLII", "MCCCXLIII", "MCCCXLIV", "MCCCXLV", "MCCCXLVI", "MCCCXLVII", "MCCCXLVIII", "MCCCXLIX", "MCCCL",
"MCCCLI", "MCCCLII", "MCCCLIII", "MCCCLIV", "MCCCLV", "MCCCLVI", "MCCCLVII", "MCCCLVIII", "MCCCLIX", "MCCCLX", "MCCCLXI", "MCCCLXII", "MCCCLXIII", "MCCCLXIV", "MCCCLXV", "MCCCLXVI", "MCCCLXVII", "MCCCLXVIII",
"MCCCLXIX", "MCCCLXX", "MCCCLXXI", "MCCCLXXII", "MCCCLXXIII", "MCCCLXXIV", "MCCCLXXV", "MCCCLXXVI", "MCCCLXXVII", "MCCCLXXVIII", "MCCCLXXIX", "MCCCLXXX", "MCCCLXXXI", "MCCCLXXXII", "MCCCLXXXIII", "MCCCLXXXIV", "MCCCLXXXV",
"MCCCLXXXVI", "MCCCLXXXVII", "MCCCLXXXVIII", "MCCCLXXXIX", "MCCCXC", "MCCCXCI", "MCCCXCII", "MCCCXCIII", "MCCCXCIV", "MCCCXCV", "MCCCXCVI", "MCCCXCVII", "MCCCXCVIII", "MCCCXCIX", "MCD", "MCDI", "MCDII", "MCDIII",
"MCDIV", "MCDV", "MCDVI", "MCDVII", "MCDVIII", "MCDIX", "MCDX", "MCDXI", "MCDXII", "MCDXIII", "MCDXIV", "MCDXV", "MCDXVI", "MCDXVII", "MCDXVIII", "MCDXIX", "MCDXX", "MCDXXI", "MCDXXII", "MCDXXIII", "MCDXXIV",
"MCDXXV", "MCDXXVI", "MCDXXVII", "MCDXXVIII", "MCDXXIX", "MCDXXX", "MCDXXXI", "MCDXXXII", "MCDXXXIII", "MCDXXXIV", "MCDXXXV", "MCDXXXVI", "MCDXXXVII", "MCDXXXVIII", "MCDXXXIX", "MCDXL", "MCDXLI", "MCDXLII",
"MCDXLIII", "MCDXLIV", "MCDXLV", "MCDXLVI", "MCDXLVII", "MCDXLVIII", "MCDXLIX", "MCDL", "MCDLI", "MCDLII", "MCDLIII", "MCDLIV", "MCDLV", "MCDLVI", "MCDLVII", "MCDLVIII", "MCDLIX", "MCDLX", "MCDLXI", "MCDLXII", "MCDLXIII",
"MCDLXIV", "MCDLXV", "MCDLXVI", "MCDLXVII", "MCDLXVIII", "MCDLXIX", "MCDLXX", "MCDLXXI", "MCDLXXII", "MCDLXXIII", "MCDLXXIV", "MCDLXXV", "MCDLXXVI", "MCDLXXVII", "MCDLXXVIII", "MCDLXXIX", "MCDLXXX", "MCDLXXXI", "MCDLXXXII", "MCDLXXXIII",
"MCDLXXXIV", "MCDLXXXV", "MCDLXXXVI", "MCDLXXXVII", "MCDLXXXVIII", "MCDLXXXIX", "MCDXC", "MCDXCI", "MCDXCII", "MCDXCIII", "MCDXCIV", "MCDXCV", "MCDXCVI", "MCDXCVII", "MCDXCVIII", "MCDXCIX", "MD", "MDI", "MDII", "MDIII",
"MDIV", "MDV", "MDVI", "MDVII", "MDVIII", "MDIX", "MDX", "MDXI", "MDXII", "MDXIII", "MDXIV", "MDXV", "MDXVI", "MDXVII", "MDXVIII", "MDXIX", "MDXX", "MDXXI", "MDXXII", "MDXXIII", "MDXXIV", "MDXXV", "MDXXVI", "MDXXVII",
"MDXXVIII", "MDXXIX", "MDXXX", "MDXXXI", "MDXXXII", "MDXXXIII", "MDXXXIV", "MDXXXV", "MDXXXVI", "MDXXXVII", "MDXXXVIII", "MDXXXIX", "MDXL", "MDXLI", "MDXLII", "MDXLIII", "MDXLIV", "MDXLV", "MDXLVI", "MDXLVII", "MDXLVIII",
"MDXLIX", "MDL", "MDLI", "MDLII", "MDLIII", "MDLIV", "MDLV", "MDLVI", "MDLVII", "MDLVIII", "MDLIX", "MDLX", "MDLXI", "MDLXII", "MDLXIII", "MDLXIV", "MDLXV", "MDLXVI", "MDLXVII", "MDLXVIII", "MDLXIX", "MDLXX", "MDLXXI",
"MDLXXII", "MDLXXIII", "MDLXXIV", "MDLXXV", "MDLXXVI", "MDLXXVII", "MDLXXVIII", "MDLXXIX", "MDLXXX", "MDLXXXI", "MDLXXXII", "MDLXXXIII", "MDLXXXIV", "MDLXXXV", "MDLXXXVI", "MDLXXXVII", "MDLXXXVIII", "MDLXXXIX",
"MDXC", "MDXCI", "MDXCII", "MDXCIII", "MDXCIV", "MDXCV", "MDXCVI", "MDXCVII", "MDXCVIII", "MDXCIX", "MDC", "MDCI", "MDCII", "MDCIII", "MDCIV", "MDCV", "MDCVI", "MDCVII", "MDCVIII", "MDCIX", "MDCX", "MDCXI", "MDCXII",
"MDCXIII", "MDCXIV", "MDCXV", "MDCXVI", "MDCXVII", "MDCXVIII", "MDCXIX", "MDCXX", "MDCXXI", "MDCXXII", "MDCXXIII", "MDCXXIV", "MDCXXV", "MDCXXVI", "MDCXXVII", "MDCXXVIII", "MDCXXIX", "MDCXXX", "MDCXXXI", "MDCXXXII",
"MDCXXXIII", "MDCXXXIV", "MDCXXXV", "MDCXXXVI", "MDCXXXVII", "MDCXXXVIII", "MDCXXXIX", "MDCXL", "MDCXLI", "MDCXLII", "MDCXLIII", "MDCXLIV", "MDCXLV", "MDCXLVI", "MDCXLVII", "MDCXLVIII", "MDCXLIX", "MDCL", "MDCLI",
"MDCLII", "MDCLIII", "MDCLIV", "MDCLV", "MDCLVI", "MDCLVII", "MDCLVIII", "MDCLIX", "MDCLX", "MDCLXI", "MDCLXII", "MDCLXIII", "MDCLXIV", "MDCLXV", "MDCLXVI", "MDCLXVII", "MDCLXVIII", "MDCLXIX", "MDCLXX", "MDCLXXI",
"MDCLXXII", "MDCLXXIII", "MDCLXXIV", "MDCLXXV", "MDCLXXVI", "MDCLXXVII", "MDCLXXVIII", "MDCLXXIX", "MDCLXXX", "MDCLXXXI", "MDCLXXXII", "MDCLXXXIII", "MDCLXXXIV", "MDCLXXXV", "MDCLXXXVI", "MDCLXXXVII", "MDCLXXXVIII",
"MDCLXXXIX", "MDCXC", "MDCXCI", "MDCXCII", "MDCXCIII", "MDCXCIV", "MDCXCV", "MDCXCVI", "MDCXCVII", "MDCXCVIII", "MDCXCIX", "MDCC", "MDCCI", "MDCCII", "MDCCIII", "MDCCIV", "MDCCV", "MDCCVI", "MDCCVII", "MDCCVIII", "MDCCIX",
"MDCCX", "MDCCXI", "MDCCXII", "MDCCXIII", "MDCCXIV", "MDCCXV", "MDCCXVI", "MDCCXVII", "MDCCXVIII", "MDCCXIX", "MDCCXX", "MDCCXXI", "MDCCXXII", "MDCCXXIII", "MDCCXXIV", "MDCCXXV", "MDCCXXVI", "MDCCXXVII", "MDCCXXVIII", "MDCCXXIX",
"MDCCXXX", "MDCCXXXI", "MDCCXXXII", "MDCCXXXIII", "MDCCXXXIV", "MDCCXXXV", "MDCCXXXVI", "MDCCXXXVII", "MDCCXXXVIII", "MDCCXXXIX", "MDCCXL", "MDCCXLI", "MDCCXLII", "MDCCXLIII", "MDCCXLIV", "MDCCXLV", "MDCCXLVI", "MDCCXLVII",
"MDCCXLVIII", "MDCCXLIX", "MDCCL", "MDCCLI", "MDCCLII", "MDCCLIII", "MDCCLIV", "MDCCLV", "MDCCLVI", "MDCCLVII", "MDCCLVIII", "MDCCLIX", "MDCCLX", "MDCCLXI", "MDCCLXII", "MDCCLXIII", "MDCCLXIV", "MDCCLXV", "MDCCLXVI",
"MDCCLXVII", "MDCCLXVIII", "MDCCLXIX", "MDCCLXX", "MDCCLXXI", "MDCCLXXII", "MDCCLXXIII", "MDCCLXXIV", "MDCCLXXV", "MDCCLXXVI", "MDCCLXXVII", "MDCCLXXVIII", "MDCCLXXIX", "MDCCLXXX", "MDCCLXXXI", "MDCCLXXXII", "MDCCLXXXIII",
"MDCCLXXXIV", "MDCCLXXXV", "MDCCLXXXVI", "MDCCLXXXVII", "MDCCLXXXVIII", "MDCCLXXXIX", "MDCCXC", "MDCCXCI", "MDCCXCII", "MDCCXCIII", "MDCCXCIV", "MDCCXCV", "MDCCXCVI", "MDCCXCVII", "MDCCXCVIII", "MDCCXCIX", "MDCCC", "MDCCCI",
"MDCCCII", "MDCCCIII", "MDCCCIV", "MDCCCV", "MDCCCVI", "MDCCCVII", "MDCCCVIII", "MDCCCIX", "MDCCCX", "MDCCCXI", "MDCCCXII", "MDCCCXIII", "MDCCCXIV", "MDCCCXV", "MDCCCXVI", "MDCCCXVII", "MDCCCXVIII", "MDCCCXIX", "MDCCCXX",
"MDCCCXXI", "MDCCCXXII", "MDCCCXXIII", "MDCCCXXIV", "MDCCCXXV", "MDCCCXXVI", "MDCCCXXVII", "MDCCCXXVIII", "MDCCCXXIX", "MDCCCXXX", "MDCCCXXXI", "MDCCCXXXII", "MDCCCXXXIII", "MDCCCXXXIV", "MDCCCXXXV", "MDCCCXXXVI", "MDCCCXXXVII",
"MDCCCXXXVIII", "MDCCCXXXIX", "MDCCCXL", "MDCCCXLI", "MDCCCXLII", "MDCCCXLIII", "MDCCCXLIV", "MDCCCXLV", "MDCCCXLVI", "MDCCCXLVII", "MDCCCXLVIII", "MDCCCXLIX", "MDCCCL", "MDCCCLI", "MDCCCLII", "MDCCCLIII", "MDCCCLIV",
"MDCCCLV", "MDCCCLVI", "MDCCCLVII", "MDCCCLVIII", "MDCCCLIX", "MDCCCLX", "MDCCCLXI", "MDCCCLXII", "MDCCCLXIII", "MDCCCLXIV", "MDCCCLXV", "MDCCCLXVI", "MDCCCLXVII", "MDCCCLXVIII", "MDCCCLXIX", "MDCCCLXX",
"MDCCCLXXI", "MDCCCLXXII", "MDCCCLXXIII", "MDCCCLXXIV", "MDCCCLXXV", "MDCCCLXXVI", "MDCCCLXXVII", "MDCCCLXXVIII", "MDCCCLXXIX", "MDCCCLXXX", "MDCCCLXXXI", "MDCCCLXXXII", "MDCCCLXXXIII", "MDCCCLXXXIV", "MDCCCLXXXV",
"MDCCCLXXXVI", "MDCCCLXXXVII", "MDCCCLXXXVIII", "MDCCCLXXXIX", "MDCCCXC", "MDCCCXCI", "MDCCCXCII", "MDCCCXCIII", "MDCCCXCIV", "MDCCCXCV", "MDCCCXCVI", "MDCCCXCVII", "MDCCCXCVIII", "MDCCCXCIX", "MCM", "MCMI",
"MCMII", "MCMIII", "MCMIV", "MCMV", "MCMVI", "MCMVII", "MCMVIII", "MCMIX", "MCMX", "MCMXI", "MCMXII", "MCMXIII", "MCMXIV", "MCMXV", "MCMXVI", "MCMXVII", "MCMXVIII", "MCMXIX", "MCMXX", "MCMXXI", "MCMXXII", "MCMXXIII", "MCMXXIV",
"MCMXXV", "MCMXXVI", "MCMXXVII", "MCMXXVIII", "MCMXXIX", "MCMXXX", "MCMXXXI", "MCMXXXII", "MCMXXXIII", "MCMXXXIV", "MCMXXXV", "MCMXXXVI", "MCMXXXVII", "MCMXXXVIII", "MCMXXXIX", "MCMXL", "MCMXLI", "MCMXLII",
"MCMXLIII", "MCMXLIV", "MCMXLV", "MCMXLVI", "MCMXLVII", "MCMXLVIII", "MCMXLIX", "MCML", "MCMLI", "MCMLII", "MCMLIII", "MCMLIV", "MCMLV", "MCMLVI", "MCMLVII", "MCMLVIII", "MCMLIX", "MCMLX", "MCMLXI", "MCMLXII", "MCMLXIII", "MCMLXIV",
"MCMLXV", "MCMLXVI", "MCMLXVII", "MCMLXVIII", "MCMLXIX", "MCMLXX", "MCMLXXI", "MCMLXXII", "MCMLXXIII", "MCMLXXIV", "MCMLXXV", "MCMLXXVI", "MCMLXXVII", "MCMLXXVIII", "MCMLXXIX", "MCMLXXX", "MCMLXXXI", "MCMLXXXII",
"MCMLXXXIII", "MCMLXXXIV", "MCMLXXXV", "MCMLXXXVI", "MCMLXXXVII", "MCMLXXXVIII", "MCMLXXXIX", "MCMXC", "MCMXCI", "MCMXCII", "MCMXCIII", "MCMXCIV", "MCMXCV", "MCMXCVI", "MCMXCVII", "MCMXCVIII", "MCMXCIX", "MM", "MMI",
"MMII", "MMIII", "MMIV", "MMV", "MMVI", "MMVII", "MMVIII", "MMIX", "MMX", "MMXI", "MMXII", "MMXIII", "MMXIV", "MMXV", "MMXVI", "MMXVII", "MMXVIII", "MMXIX", "MMXX", "MMXXI", "MMXXII", "MMXXIII", "MMXXIV", "MMXXV",
"MMXXVI", "MMXXVII", "MMXXVIII", "MMXXIX", "MMXXX", "MMXXXI", "MMXXXII", "MMXXXIII", "MMXXXIV", "MMXXXV", "MMXXXVI", "MMXXXVII", "MMXXXVIII", "MMXXXIX", "MMXL", "MMXLI", "MMXLII", "MMXLIII", "MMXLIV", "MMXLV", "MMXLVI",
"MMXLVII", "MMXLVIII", "MMXLIX", "MML", "MMLI", "MMLII", "MMLIII", "MMLIV", "MMLV", "MMLVI", "MMLVII", "MMLVIII", "MMLIX", "MMLX", "MMLXI", "MMLXII", "MMLXIII", "MMLXIV", "MMLXV", "MMLXVI", "MMLXVII", "MMLXVIII", "MMLXIX",
"MMLXX", "MMLXXI", "MMLXXII", "MMLXXIII", "MMLXXIV", "MMLXXV", "MMLXXVI", "MMLXXVII", "MMLXXVIII", "MMLXXIX", "MMLXXX", "MMLXXXI", "MMLXXXII", "MMLXXXIII", "MMLXXXIV", "MMLXXXV", "MMLXXXVI", "MMLXXXVII", "MMLXXXVIII", "MMLXXXIX",
"MMXC", "MMXCI", "MMXCII", "MMXCIII", "MMXCIV", "MMXCV", "MMXCVI", "MMXCVII", "MMXCVIII", "MMXCIX", "MMC", "MMCI", "MMCII", "MMCIII", "MMCIV", "MMCV", "MMCVI", "MMCVII", "MMCVIII", "MMCIX", "MMCX", "MMCXI", "MMCXII", "MMCXIII", "MMCXIV",
"MMCXV", "MMCXVI", "MMCXVII", "MMCXVIII", "MMCXIX", "MMCXX", "MMCXXI", "MMCXXII", "MMCXXIII", "MMCXXIV", "MMCXXV", "MMCXXVI", "MMCXXVII", "MMCXXVIII", "MMCXXIX", "MMCXXX", "MMCXXXI", "MMCXXXII", "MMCXXXIII",
"MMCXXXIV", "MMCXXXV", "MMCXXXVI", "MMCXXXVII", "MMCXXXVIII", "MMCXXXIX", "MMCXL", "MMCXLI", "MMCXLII", "MMCXLIII", "MMCXLIV", "MMCXLV", "MMCXLVI", "MMCXLVII", "MMCXLVIII", "MMCXLIX", "MMCL", "MMCLI", "MMCLII", "MMCLIII",
"MMCLIV", "MMCLV", "MMCLVI", "MMCLVII", "MMCLVIII", "MMCLIX", "MMCLX", "MMCLXI", "MMCLXII", "MMCLXIII", "MMCLXIV", "MMCLXV", "MMCLXVI", "MMCLXVII", "MMCLXVIII", "MMCLXIX", "MMCLXX", "MMCLXXI", "MMCLXXII", "MMCLXXIII",
"MMCLXXIV", "MMCLXXV", "MMCLXXVI", "MMCLXXVII", "MMCLXXVIII", "MMCLXXIX", "MMCLXXX", "MMCLXXXI", "MMCLXXXII", "MMCLXXXIII", "MMCLXXXIV", "MMCLXXXV", "MMCLXXXVI", "MMCLXXXVII", "MMCLXXXVIII", "MMCLXXXIX", "MMCXC",
"MMCXCI", "MMCXCII", "MMCXCIII", "MMCXCIV", "MMCXCV", "MMCXCVI", "MMCXCVII", "MMCXCVIII", "MMCXCIX", "MMCC", "MMCCI", "MMCCII", "MMCCIII", "MMCCIV", "MMCCV", "MMCCVI", "MMCCVII", "MMCCVIII", "MMCCIX", "MMCCX", "MMCCXI",
"MMCCXII", "MMCCXIII", "MMCCXIV", "MMCCXV", "MMCCXVI", "MMCCXVII", "MMCCXVIII", "MMCCXIX", "MMCCXX", "MMCCXXI", "MMCCXXII", "MMCCXXIII", "MMCCXXIV", "MMCCXXV", "MMCCXXVI", "MMCCXXVII", "MMCCXXVIII", "MMCCXXIX", "MMCCXXX",
"MMCCXXXI", "MMCCXXXII", "MMCCXXXIII", "MMCCXXXIV", "MMCCXXXV", "MMCCXXXVI", "MMCCXXXVII", "MMCCXXXVIII", "MMCCXXXIX", "MMCCXL", "MMCCXLI", "MMCCXLII", "MMCCXLIII", "MMCCXLIV", "MMCCXLV", "MMCCXLVI", "MMCCXLVII", "MMCCXLVIII", "MMCCXLIX",
"MMCCL", "MMCCLI", "MMCCLII", "MMCCLIII", "MMCCLIV", "MMCCLV", "MMCCLVI", "MMCCLVII", "MMCCLVIII", "MMCCLIX", "MMCCLX", "MMCCLXI", "MMCCLXII", "MMCCLXIII", "MMCCLXIV", "MMCCLXV", "MMCCLXVI", "MMCCLXVII", "MMCCLXVIII",
"MMCCLXIX", "MMCCLXX", "MMCCLXXI", "MMCCLXXII", "MMCCLXXIII", "MMCCLXXIV", "MMCCLXXV", "MMCCLXXVI", "MMCCLXXVII", "MMCCLXXVIII", "MMCCLXXIX", "MMCCLXXX", "MMCCLXXXI", "MMCCLXXXII", "MMCCLXXXIII", "MMCCLXXXIV", "MMCCLXXXV",
"MMCCLXXXVI", "MMCCLXXXVII", "MMCCLXXXVIII", "MMCCLXXXIX", "MMCCXC", "MMCCXCI", "MMCCXCII", "MMCCXCIII", "MMCCXCIV", "MMCCXCV", "MMCCXCVI", "MMCCXCVII", "MMCCXCVIII", "MMCCXCIX", "MMCCC", "MMCCCI", "MMCCCII", "MMCCCIII",
"MMCCCIV", "MMCCCV", "MMCCCVI", "MMCCCVII", "MMCCCVIII", "MMCCCIX", "MMCCCX", "MMCCCXI", "MMCCCXII", "MMCCCXIII", "MMCCCXIV", "MMCCCXV", "MMCCCXVI", "MMCCCXVII", "MMCCCXVIII", "MMCCCXIX", "MMCCCXX", "MMCCCXXI", "MMCCCXXII",
"MMCCCXXIII", "MMCCCXXIV", "MMCCCXXV", "MMCCCXXVI", "MMCCCXXVII", "MMCCCXXVIII", "MMCCCXXIX", "MMCCCXXX", "MMCCCXXXI", "MMCCCXXXII", "MMCCCXXXIII", "MMCCCXXXIV", "MMCCCXXXV", "MMCCCXXXVI", "MMCCCXXXVII", "MMCCCXXXVIII",
"MMCCCXXXIX", "MMCCCXL", "MMCCCXLI", "MMCCCXLII", "MMCCCXLIII", "MMCCCXLIV", "MMCCCXLV", "MMCCCXLVI", "MMCCCXLVII", "MMCCCXLVIII", "MMCCCXLIX", "MMCCCL", "MMCCCLI", "MMCCCLII", "MMCCCLIII", "MMCCCLIV", "MMCCCLV",
"MMCCCLVI", "MMCCCLVII", "MMCCCLVIII", "MMCCCLIX", "MMCCCLX", "MMCCCLXI", "MMCCCLXII", "MMCCCLXIII", "MMCCCLXIV", "MMCCCLXV", "MMCCCLXVI", "MMCCCLXVII", "MMCCCLXVIII", "MMCCCLXIX", "MMCCCLXX", "MMCCCLXXI", "MMCCCLXXII",
"MMCCCLXXIII", "MMCCCLXXIV", "MMCCCLXXV", "MMCCCLXXVI", "MMCCCLXXVII", "MMCCCLXXVIII", "MMCCCLXXIX", "MMCCCLXXX", "MMCCCLXXXI", "MMCCCLXXXII", "MMCCCLXXXIII", "MMCCCLXXXIV", "MMCCCLXXXV", "MMCCCLXXXVI", "MMCCCLXXXVII", "MMCCCLXXXVIII",
"MMCCCLXXXIX", "MMCCCXC", "MMCCCXCI", "MMCCCXCII", "MMCCCXCIII", "MMCCCXCIV", "MMCCCXCV", "MMCCCXCVI", "MMCCCXCVII", "MMCCCXCVIII", "MMCCCXCIX", "MMCD", "MMCDI", "MMCDII", "MMCDIII", "MMCDIV", "MMCDV", "MMCDVI", "MMCDVII",
"MMCDVIII", "MMCDIX", "MMCDX", "MMCDXI", "MMCDXII", "MMCDXIII", "MMCDXIV", "MMCDXV", "MMCDXVI", "MMCDXVII", "MMCDXVIII", "MMCDXIX", "MMCDXX", "MMCDXXI", "MMCDXXII", "MMCDXXIII", "MMCDXXIV", "MMCDXXV", "MMCDXXVI", "MMCDXXVII",
"MMCDXXVIII", "MMCDXXIX", "MMCDXXX", "MMCDXXXI", "MMCDXXXII", "MMCDXXXIII", "MMCDXXXIV", "MMCDXXXV", "MMCDXXXVI", "MMCDXXXVII", "MMCDXXXVIII", "MMCDXXXIX", "MMCDXL", "MMCDXLI", "MMCDXLII", "MMCDXLIII", "MMCDXLIV",
"MMCDXLV", "MMCDXLVI", "MMCDXLVII", "MMCDXLVIII", "MMCDXLIX", "MMCDL", "MMCDLI", "MMCDLII", "MMCDLIII", "MMCDLIV", "MMCDLV", "MMCDLVI", "MMCDLVII", "MMCDLVIII", "MMCDLIX", "MMCDLX", "MMCDLXI", "MMCDLXII", "MMCDLXIII",
"MMCDLXIV", "MMCDLXV", "MMCDLXVI", "MMCDLXVII", "MMCDLXVIII", "MMCDLXIX", "MMCDLXX", "MMCDLXXI", "MMCDLXXII", "MMCDLXXIII", "MMCDLXXIV", "MMCDLXXV", "MMCDLXXVI", "MMCDLXXVII", "MMCDLXXVIII", "MMCDLXXIX", "MMCDLXXX",
"MMCDLXXXI", "MMCDLXXXII", "MMCDLXXXIII", "MMCDLXXXIV", "MMCDLXXXV", "MMCDLXXXVI", "MMCDLXXXVII", "MMCDLXXXVIII", "MMCDLXXXIX", "MMCDXC", "MMCDXCI", "MMCDXCII", "MMCDXCIII", "MMCDXCIV", "MMCDXCV",
"MMCDXCVI", "MMCDXCVII", "MMCDXCVIII", "MMCDXCIX", "MMD", "MMDI", "MMDII", "MMDIII", "MMDIV", "MMDV", "MMDVI", "MMDVII", "MMDVIII", "MMDIX", "MMDX", "MMDXI", "MMDXII", "MMDXIII", "MMDXIV", "MMDXV", "MMDXVI", "MMDXVII",
"MMDXVIII", "MMDXIX", "MMDXX", "MMDXXI", "MMDXXII", "MMDXXIII", "MMDXXIV", "MMDXXV", "MMDXXVI", "MMDXXVII", "MMDXXVIII", "MMDXXIX", "MMDXXX", "MMDXXXI", "MMDXXXII", "MMDXXXIII", "MMDXXXIV", "MMDXXXV", "MMDXXXVI", "MMDXXXVII",
"MMDXXXVIII", "MMDXXXIX", "MMDXL", "MMDXLI", "MMDXLII", "MMDXLIII", "MMDXLIV", "MMDXLV", "MMDXLVI", "MMDXLVII", "MMDXLVIII", "MMDXLIX", "MMDL", "MMDLI", "MMDLII", "MMDLIII", "MMDLIV", "MMDLV", "MMDLVI", "MMDLVII", "MMDLVIII", "MMDLIX",
"MMDLX", "MMDLXI", "MMDLXII", "MMDLXIII", "MMDLXIV", "MMDLXV", "MMDLXVI", "MMDLXVII", "MMDLXVIII", "MMDLXIX", "MMDLXX", "MMDLXXI", "MMDLXXII", "MMDLXXIII", "MMDLXXIV", "MMDLXXV", "MMDLXXVI", "MMDLXXVII", "MMDLXXVIII",
"MMDLXXIX", "MMDLXXX", "MMDLXXXI", "MMDLXXXII", "MMDLXXXIII", "MMDLXXXIV", "MMDLXXXV", "MMDLXXXVI", "MMDLXXXVII", "MMDLXXXVIII", "MMDLXXXIX", "MMDXC", "MMDXCI", "MMDXCII", "MMDXCIII", "MMDXCIV", "MMDXCV", "MMDXCVI",
"MMDXCVII", "MMDXCVIII", "MMDXCIX", "MMDC", "MMDCI", "MMDCII", "MMDCIII", "MMDCIV", "MMDCV", "MMDCVI", "MMDCVII", "MMDCVIII", "MMDCIX", "MMDCX", "MMDCXI", "MMDCXII", "MMDCXIII", "MMDCXIV", "MMDCXV", "MMDCXVI", "MMDCXVII",
"MMDCXVIII", "MMDCXIX", "MMDCXX", "MMDCXXI", "MMDCXXII", "MMDCXXIII", "MMDCXXIV", "MMDCXXV", "MMDCXXVI", "MMDCXXVII", "MMDCXXVIII", "MMDCXXIX", "MMDCXXX", "MMDCXXXI", "MMDCXXXII", "MMDCXXXIII", "MMDCXXXIV", "MMDCXXXV",
"MMDCXXXVI", "MMDCXXXVII", "MMDCXXXVIII", "MMDCXXXIX", "MMDCXL", "MMDCXLI", "MMDCXLII", "MMDCXLIII", "MMDCXLIV", "MMDCXLV", "MMDCXLVI", "MMDCXLVII", "MMDCXLVIII", "MMDCXLIX", "MMDCL", "MMDCLI", "MMDCLII", "MMDCLIII",
"MMDCLIV", "MMDCLV", "MMDCLVI", "MMDCLVII", "MMDCLVIII", "MMDCLIX", "MMDCLX", "MMDCLXI", "MMDCLXII", "MMDCLXIII", "MMDCLXIV", "MMDCLXV", "MMDCLXVI", "MMDCLXVII", "MMDCLXVIII", "MMDCLXIX", "MMDCLXX", "MMDCLXXI", "MMDCLXXII", "MMDCLXXIII",
"MMDCLXXIV", "MMDCLXXV", "MMDCLXXVI", "MMDCLXXVII", "MMDCLXXVIII", "MMDCLXXIX", "MMDCLXXX", "MMDCLXXXI", "MMDCLXXXII", "MMDCLXXXIII", "MMDCLXXXIV", "MMDCLXXXV", "MMDCLXXXVI", "MMDCLXXXVII", "MMDCLXXXVIII", "MMDCLXXXIX", "MMDCXC",
"MMDCXCI", "MMDCXCII", "MMDCXCIII", "MMDCXCIV", "MMDCXCV", "MMDCXCVI", "MMDCXCVII", "MMDCXCVIII", "MMDCXCIX", "MMDCC", "MMDCCI", "MMDCCII", "MMDCCIII", "MMDCCIV", "MMDCCV", "MMDCCVI", "MMDCCVII", "MMDCCVIII",
"MMDCCIX", "MMDCCX", "MMDCCXI", "MMDCCXII", "MMDCCXIII", "MMDCCXIV", "MMDCCXV", "MMDCCXVI", "MMDCCXVII", "MMDCCXVIII", "MMDCCXIX", "MMDCCXX", "MMDCCXXI", "MMDCCXXII", "MMDCCXXIII", "MMDCCXXIV", "MMDCCXXV", "MMDCCXXVI",
"MMDCCXXVII", "MMDCCXXVIII", "MMDCCXXIX", "MMDCCXXX", "MMDCCXXXI", "MMDCCXXXII", "MMDCCXXXIII", "MMDCCXXXIV", "MMDCCXXXV", "MMDCCXXXVI", "MMDCCXXXVII", "MMDCCXXXVIII", "MMDCCXXXIX", "MMDCCXL", "MMDCCXLI",
"MMDCCXLII", "MMDCCXLIII", "MMDCCXLIV", "MMDCCXLV", "MMDCCXLVI", "MMDCCXLVII", "MMDCCXLVIII", "MMDCCXLIX", "MMDCCL", "MMDCCLI", "MMDCCLII", "MMDCCLIII", "MMDCCLIV", "MMDCCLV", "MMDCCLVI", "MMDCCLVII", "MMDCCLVIII",
"MMDCCLIX", "MMDCCLX", "MMDCCLXI", "MMDCCLXII", "MMDCCLXIII", "MMDCCLXIV", "MMDCCLXV", "MMDCCLXVI", "MMDCCLXVII", "MMDCCLXVIII", "MMDCCLXIX", "MMDCCLXX", "MMDCCLXXI", "MMDCCLXXII", "MMDCCLXXIII", "MMDCCLXXIV",
"MMDCCLXXV", "MMDCCLXXVI", "MMDCCLXXVII", "MMDCCLXXVIII", "MMDCCLXXIX", "MMDCCLXXX", "MMDCCLXXXI", "MMDCCLXXXII", "MMDCCLXXXIII", "MMDCCLXXXIV", "MMDCCLXXXV", "MMDCCLXXXVI", "MMDCCLXXXVII", "MMDCCLXXXVIII", "MMDCCLXXXIX", "MMDCCXC",
"MMDCCXCI", "MMDCCXCII", "MMDCCXCIII", "MMDCCXCIV", "MMDCCXCV", "MMDCCXCVI", "MMDCCXCVII", "MMDCCXCVIII", "MMDCCXCIX", "MMDCCC", "MMDCCCI", "MMDCCCII", "MMDCCCIII", "MMDCCCIV", "MMDCCCV", "MMDCCCVI", "MMDCCCVII", "MMDCCCVIII",
"MMDCCCIX", "MMDCCCX", "MMDCCCXI", "MMDCCCXII", "MMDCCCXIII", "MMDCCCXIV", "MMDCCCXV", "MMDCCCXVI", "MMDCCCXVII", "MMDCCCXVIII", "MMDCCCXIX", "MMDCCCXX", "MMDCCCXXI", "MMDCCCXXII", "MMDCCCXXIII", "MMDCCCXXIV", "MMDCCCXXV",
"MMDCCCXXVI", "MMDCCCXXVII", "MMDCCCXXVIII", "MMDCCCXXIX", "MMDCCCXXX", "MMDCCCXXXI", "MMDCCCXXXII", "MMDCCCXXXIII", "MMDCCCXXXIV", "MMDCCCXXXV", "MMDCCCXXXVI", "MMDCCCXXXVII", "MMDCCCXXXVIII", "MMDCCCXXXIX",
"MMDCCCXL", "MMDCCCXLI", "MMDCCCXLII", "MMDCCCXLIII", "MMDCCCXLIV", "MMDCCCXLV", "MMDCCCXLVI", "MMDCCCXLVII", "MMDCCCXLVIII", "MMDCCCXLIX", "MMDCCCL", "MMDCCCLI", "MMDCCCLII", "MMDCCCLIII", "MMDCCCLIV",
"MMDCCCLV", "MMDCCCLVI", "MMDCCCLVII", "MMDCCCLVIII", "MMDCCCLIX", "MMDCCCLX", "MMDCCCLXI", "MMDCCCLXII", "MMDCCCLXIII", "MMDCCCLXIV", "MMDCCCLXV", "MMDCCCLXVI", "MMDCCCLXVII", "MMDCCCLXVIII", "MMDCCCLXIX",
"MMDCCCLXX", "MMDCCCLXXI", "MMDCCCLXXII", "MMDCCCLXXIII", "MMDCCCLXXIV", "MMDCCCLXXV", "MMDCCCLXXVI", "MMDCCCLXXVII", "MMDCCCLXXVIII", "MMDCCCLXXIX", "MMDCCCLXXX", "MMDCCCLXXXI", "MMDCCCLXXXII", "MMDCCCLXXXIII",
"MMDCCCLXXXIV", "MMDCCCLXXXV", "MMDCCCLXXXVI", "MMDCCCLXXXVII", "MMDCCCLXXXVIII", "MMDCCCLXXXIX", "MMDCCCXC", "MMDCCCXCI", "MMDCCCXCII", "MMDCCCXCIII", "MMDCCCXCIV", "MMDCCCXCV", "MMDCCCXCVI", "MMDCCCXCVII", "MMDCCCXCVIII",
"MMDCCCXCIX", "MMCM", "MMCMI", "MMCMII", "MMCMIII", "MMCMIV", "MMCMV", "MMCMVI", "MMCMVII", "MMCMVIII", "MMCMIX", "MMCMX", "MMCMXI", "MMCMXII", "MMCMXIII", "MMCMXIV", "MMCMXV", "MMCMXVI", "MMCMXVII", "MMCMXVIII", "MMCMXIX",
"MMCMXX", "MMCMXXI", "MMCMXXII", "MMCMXXIII", "MMCMXXIV", "MMCMXXV", "MMCMXXVI", "MMCMXXVII", "MMCMXXVIII", "MMCMXXIX", "MMCMXXX", "MMCMXXXI", "MMCMXXXII", "MMCMXXXIII", "MMCMXXXIV", "MMCMXXXV", "MMCMXXXVI", "MMCMXXXVII",
"MMCMXXXVIII", "MMCMXXXIX", "MMCMXL", "MMCMXLI", "MMCMXLII", "MMCMXLIII", "MMCMXLIV", "MMCMXLV", "MMCMXLVI", "MMCMXLVII", "MMCMXLVIII", "MMCMXLIX", "MMCML", "MMCMLI", "MMCMLII", "MMCMLIII", "MMCMLIV", "MMCMLV", "MMCMLVI",
"MMCMLVII", "MMCMLVIII", "MMCMLIX", "MMCMLX", "MMCMLXI", "MMCMLXII", "MMCMLXIII", "MMCMLXIV", "MMCMLXV", "MMCMLXVI", "MMCMLXVII", "MMCMLXVIII", "MMCMLXIX", "MMCMLXX", "MMCMLXXI", "MMCMLXXII", "MMCMLXXIII", "MMCMLXXIV",
"MMCMLXXV", "MMCMLXXVI", "MMCMLXXVII", "MMCMLXXVIII", "MMCMLXXIX", "MMCMLXXX", "MMCMLXXXI", "MMCMLXXXII", "MMCMLXXXIII", "MMCMLXXXIV", "MMCMLXXXV", "MMCMLXXXVI", "MMCMLXXXVII", "MMCMLXXXVIII", "MMCMLXXXIX", "MMCMXC",
"MMCMXCI", "MMCMXCII", "MMCMXCIII", "MMCMXCIV", "MMCMXCV", "MMCMXCVI", "MMCMXCVII", "MMCMXCVIII", "MMCMXCIX", "MMM" };
        public NumerosRomanos()
        {
            InitializeComponent();
        }

        private void txtNumeroNormal_TextChanged(object sender, EventArgs e)
        {
            if (txtNumeroNormal.Text != string.Empty)
            {
                try
                {
                    txtNumeroRomano.Text = numRomanos[Convert.ToInt32(txtNumeroNormal.Text)];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Maximo 4 digitos!!");
                    txtNumeroNormal.Text = txtNumeroNormal.Text.Substring(0, 4);
                }
            }
            else
                txtNumeroRomano.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuOpciones MO = new MenuOpciones();
            MO.Show();
            this.Hide();
        }
    }
}
