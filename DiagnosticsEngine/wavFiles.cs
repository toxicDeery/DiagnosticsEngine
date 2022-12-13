using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosticsEngine
{
    class wavFiles
    {
        Int32 chunkID;
        Int32 chunkSize;
        Int32 format;
        Int32 subchunk1ID;
        Int32 subchunk1Size;
        Int16 audioFormat;
        Int16 numChannels;
        Int32 sampleRate;
        Int32 byteRate;
        Int16 blockAlign;
        Int16 bitsPerSample;
        Int32 subchunk2ID;
        Int32 subchunk2Size;
        public byte[] data;
        
        public wavFiles(byte[] buffer)
        {
            this.chunkID = BitConverter.ToInt32(buffer, 0);
            this.chunkSize = BitConverter.ToInt32(buffer, 4);
            this.format = BitConverter.ToInt32(buffer, 8);
            this.subchunk1ID = BitConverter.ToInt32(buffer, 12);
            this.subchunk1Size = BitConverter.ToInt32(buffer, 16);
            this.audioFormat = BitConverter.ToInt16(buffer, 20);
            this.numChannels = BitConverter.ToInt16(buffer, 22);
            this.sampleRate = BitConverter.ToInt32(buffer, 24);
            this.byteRate = BitConverter.ToInt32(buffer, 28);
            this.blockAlign = BitConverter.ToInt16(buffer, 32);
            this.bitsPerSample = BitConverter.ToInt16(buffer, 34);
            this.subchunk2ID = BitConverter.ToInt32(buffer, 36);
            this.subchunk2Size = BitConverter.ToInt32(buffer, 40);

            data = new byte[this.subchunk2Size];
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = buffer[44 + i];
            }
        }

        public wavFiles(Int16[] mesAmps)
        {

        }

        public string getFormatAudio()
        {
            string format = "Null";
            switch (this.audioFormat)
            {
                case 1:
                    format = "WAVE_FORMAT_PCM";
                    break;
                case 2:
                    format = "WAVE_FORMAT_ADPCM";
                    break;
                case 3:
                    format = "WAVE_FORMAT_IEEE_FLOAT";
                    break;
                default:
                    break;
            }
            return format;
        }
        
        public int getByteRate()
        {
            return this.byteRate * 8 / 1000;
        }

        public double getDuration()
        {
            return 1.0 * this.subchunk2Size / (this.bitsPerSample / 8.0) / this.numChannels / this.sampleRate;
        }

        public int getFileSize()
        {
            return 44 + this.subchunk2Size;
        }

        public int getNumCh()
        {
            return this.numChannels;
        }

        public int getSampleRate()
        {
            return this.sampleRate;
        }

        public int getBPS()
        {
            return this.bitsPerSample;
        }
    }
    
}
