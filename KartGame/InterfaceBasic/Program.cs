using System;
using System.Collections.Generic;

namespace InterfaceBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<IPlay>{　//初期化詞
                new MusicPlayer(),　//list.Add(new MusicPlayer());
                new VideoPlayer()  
            };
            list.ForEach((v) => { v.Play();v.Stop();}); //ラムダ式
                                                        // forreach(IPlay i in list){}
        
        }
        interface IPlay
        {
            void Play();
            void Stop();
        }
        class MusicPlayer : IPlay　//Javaならimplements 
        {
            public void Play()
            {
                Console.WriteLine("音楽を再生します。");
            }

            public void Stop()
            {
                Console.WriteLine("音楽を停止します");
            }
        }
        class VideoPlayer : IPlay
        {
            public void Play()
            {
                Console.WriteLine("ビデオを再生します。");
            }

            public void Stop()
            {
                Console.WriteLine("ビデオを停止します。");
            }
        }
    }
}
