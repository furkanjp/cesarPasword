string x = "rczpgijcp dspiyl bckgpryq, empct gacpgeglc sjyqrgl! " +
    "gqrc zcijcbgegkgx empctgl ecpciqglgkjcpg; rcpagf crrgeglgx zgp ypiy sa bgjg (rcpagfcl hyty / em / nfn / nwrfml) tc ml wsx hq ayrgqg gjc (rcpagfcl tsc / pcyar / ylesjyp) rckcj qctgwcbc isjjylgag swcjgeg wyngjyzgjcl, mrspsk yaky tc iynyrky mxcjjgijcpglc qyfgn zgp ucz npmhcqg ecjgqrgpkcqg zcijclkcircbgp. mrspsk yayl isjjylgagjyp ylyqywdy sxcpglbc zgp ryitgk empkcjgbgp. mrspsk yakykgq mjyljyp gqc mrspsk yakywy wmljclbgpgjkcjgbgp. ryitgkbc isjjylgaglgl iclbg cijcbgeg crigljgijcp emqrcpgjkcjg, ryitgkc rgijywypyi cijckc wynyzgjkcjg tcwy crigljgeg iyjbgpyzgjkcjgbgp. " +
    "ypiy sa 3 kgapm qcptgac qcijglbc ryqypjylkyjgbgp. yaamslr qcptgac / ayjclbyp qcptgac / ucz yng qcptgac." +
    " mrspsk zgjegjcpg gagl pcbgq isjjylgjkyjgbgp. pbzkq tcwy lmqoj rcpagfg gqrcec empc wyngjyzgjgp. rsk ml wsx gqrcijcpg ucz yng qcptgac rypydglbyl iypqgjylkyjgbgp tc qcptgqjcp iclbg ypyjypglby imlsqkyjgbgp. ımb bcnmqsls zgxc gjcrgpicl qclbcl gqrcbgegkgx qyly mxcj ylyfryp imbs: eyyyyyzgpj1w5bkgp2tjkl - ozixy4aadadou7_d3ss6fqga99c5cabhn_nrja5_0tdquy3f029iy - jemsdklj1f2gjzl3awgubuormerx9khlıvclhjl6lmqcjynhubumcqolkvjbuhgblekphuah3xı0gx4haegc8i26vjzntxmnbnfpgbsq2oidvyxqhzdı0onzwn1hep35gtu8wemdaovx5k8axbdm5ovsywux9dz9hdd1f6fdds = lmrjyp; *swesjykylgl tc ecpcigwmpqy ypywsxsl bmaicp gjc lyqgj bcpjclgn ayjgqgp fyjc ecrgpgjcaceg pcybkc mjypyi wyxgjkgq mjkyjgbgp. bmaicp-amknmqc sxcpglbcl rci zgp imksr gjc ayjgqyayi qcigjbc qcptgq cbgjkcjgbgp. " +
    "tcpgryzylg egzg zyegkjgjgijyp by gacpgqglbc wcp yjkyjgbgp. * pcybkc gacpgqglbc qcptgq clbnmglr'jcpglc lyqgj gqrci yrgjyayeg, ypywsx ybpcqglgl lc mjbses egzg npmhclgl lyqgj ayjgqrgpgjyayegly bygp zgjegjcp wcp yjkyjgbgp. * wsiypgby tcpgjcl qyly mxcj ylyfryp imbs by pcybkc gacpgqglc cijclkcjgbgp. * empct gacpgeglc sjyqkyi gagl isjjylgjyl imb tc npmhc egrfsz, egrjyz, zgrzsaicr egzg cpgqgkc yagi zgp pcnm'wy emlbcpgjcpci, zyejylrg ybpcqg glqyliywlyijypg@iypryay.amk'y gjcrgjkcjgbgp. ımb bcnmqs sxcpglbcl nywjyqgk qyejylykgwmpqy, glbgpgjczgjgp bmqwyjypy sjyqkykgx gagl zgp bmqwy/zyejylrg gjcrgjkcjgbgp. empctjcpbcig rsk ecpciqglgkjcpg wcpglc ecrgpckcbgwqclgx zgjc, kmpyjglgxg zmxkywgl tc rykykjybgeglgx iybypglg zgxgkjc ksrjyiy nywjyqgl. ımjyw ecjqgl!";

string[] newX = x.Split(' ');



foreach (var item in newX)
{
    foreach (var item2 in item.ToCharArray())
    {
        var newItem2 = item2.ToString();
        switch (newItem2)
        {
            case "a":
                Console.Write("c");
                break;
            case "b":
                Console.Write("d");
                break;
            case "c":
                Console.Write("e");
                break;
            case "d":
                Console.Write("f");
                break;
            case "e":
                Console.Write("g");
                break;
            case "f":
                Console.Write("h");
                break;
            case "g":
                Console.Write("i");
                break;
            case "h":
                Console.Write("j");
                break;
            case "i":
                Console.Write("k");
                break;
            case "ı":
                Console.Write("k");
                break;
            case "j":
                Console.Write("l");
                break;
            case "k":
                Console.Write("m");
                break;
            case "l":
                Console.Write("n");
                break;
            case "m":
                Console.Write("o");
                break;
            case "n":
                Console.Write("p");
                break;
            case "o":
                Console.Write("q");
                break;
            case "p":
                Console.Write("r");
                break;
            case "r":
                Console.Write("t");
                break;
            case "R":
                Console.Write("t");
                break;
            case "s":
                Console.Write("u");
                break;
            case "t":
                Console.Write("v");
                break;
            case "u":
                Console.Write("v");
                break;
            case "v":
                Console.Write("w");
                break;
            case "w":
                Console.Write("y");
                break;
            case "x":
                Console.Write("z");
                break;
            case "y":
                Console.Write("a");
                break;
            case "z":
                Console.Write("b");
                break;
            case "q":
                Console.Write("s");
                break;
            case ".":
                Console.Write(".");
                break;
            case ",":
                Console.Write(",");
                break;
            case "*":
                Console.Write("\n*");
                break;
            case ";":
                Console.Write(";");
                break;

        }

    }
    Console.Write(" ");
}