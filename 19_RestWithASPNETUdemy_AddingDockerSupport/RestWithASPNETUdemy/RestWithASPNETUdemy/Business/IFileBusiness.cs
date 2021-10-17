using Microsoft.AspNetCore.Http;
using RestWithASPNETUdemy.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Business
{
    public interface IFileBusiness
    {
        public byte[] GetFile(string filename);
        public Task<FileDetailsVO> SaveFileToDisk(IFormFile file);
        public Task<List<FileDetailsVO>> SaveFilesToDisk(IList<IFormFile> files);
    }
}
