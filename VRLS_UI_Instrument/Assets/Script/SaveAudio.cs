using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//데이터 불러오기, 저장, 변환을 위해 필요
using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveAudio : MonoBehaviour {

    static public byte[] SaveAudioClipToWav(AudioClip audioClip, string filename)
    {
        byte[] buffer;
        FileStream fsWrite = File.Open(filename, FileMode.Create);

        BinaryWriter bw = new BinaryWriter(fsWrite);

        Byte[] header = { 82, 73, 70, 22, 10, 4, 0, 87, 65, 86, 69, 102, 109, 116, 32 };
        bw.Write(header);

        Byte[] header2 = { 16, 0, 0, 0, 1, 0, 1, 0, 68, 172, 0, 0, 136, 88, 1, 0 };
        bw.Write(header2);

        Byte[] header3 = { 2, 0, 16, 0, 100, 97, 116, 97, 152, 9, 4, 0 };
        bw.Write(header3);

        float[] samples = new float[audioClip.samples];
        audioClip.GetData(samples, 0);
        int i = 0;

        while(i<audioClip.samples)
        {
            int sampleInt = (int)(32000.0 * samples[i++]);

            int msb = sampleInt / 256;
            int lsb = sampleInt - (msb * 256);

            bw.Write((Byte)lsb);
            bw.Write((Byte)msb);
        }
        long length = fsWrite.Length;
        int lengthInt = Convert.ToInt32(length);
        buffer = new byte[lengthInt];
        fsWrite.Read(buffer, 0, lengthInt);
        return buffer;

        fsWrite.Close();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
