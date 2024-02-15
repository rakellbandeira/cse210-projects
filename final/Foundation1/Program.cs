using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();
        
        Video video1 = new Video("JavaScript DOM Manipulation", "freeCodeCamp", 7200);
        Video video2 = new Video("Introduction to DOM", "Curso em Vídeo", 1800);
        Video video3 = new Video("Javascript DOM Tutorial", "Net Ninja", 420);

        video1.SetNewComment("CodeLab98", "Thanks for watching everyone! I hope you enjoy the course and learn a lot from it!");
        video1.SetNewComment("miguelalejandrobritorausse5023", "This is just great. As a venezuelan who lives in a difficult country, i want to say thank you to all of you guys for making this tutorial and for helping us to grow as a developers. Cheers my friend");
        video1.SetNewComment("tati_edits11", "This is literally the perfect tutorial for beginners, he literally just explained it to us like we're 5 year olds.  I love it.");

        video2.SetNewComment("davidperes2557", "Pra quem baixou o live server no lugar do watch in chrome, que não está mais disponível, e não sabe como usar aqui vai uma ajudinha:");
        video2.SetNewComment("lukamorais", "Geralmente eu não comento muito o curso, mas hoje eu cheguei bem mais cansado que o comum, o dia inteiro trabalhando, cabeça explodindo, um milhão de coisas acontecendo... E eu queria falar com você, que tem milhares de outros compromissos, que chegou aqui cansado, queria dizer que você é F***!");
        video2.SetNewComment("diegoavedissian6611", "Watch in Chrome parece não estar mais disponível, fui pelo Live Server também, segundo a dica do pessoal aí nos comentários. Valeu!!!");

        video3.SetNewComment("orainizakaria", "I am learning JS DOM at 58. What a jewel!");
        video3.SetNewComment("onecarwood", "I  dont know how you do it but you are doing tutorials as I need them!");
        video3.SetNewComment("minjon56", "You are such a talented lecturer. Thank you for sharing your time and knowledge with us:)");

        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach(Video video in videosList)
        {
            video.DisplayVideo();
            video.DisplayAllComments();
        }   



    }
}