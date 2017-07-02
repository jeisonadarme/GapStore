
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Gap.Articles.Services;
using Gap.Entities.Articles;
using Gap.SuperZapatos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gap.SuperZapatos.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;
        
        public ArticleController(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
        }
        
        [HttpPost]
        public async Task<ActionResult> Create([FromBody]ArticleModel model)
        {
            var article = _mapper.Map<ArticleModel, Article>(model);
            await _articleService.Insert(article);
            return Ok(new
            {
                Success = true
            });
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await _articleService.GetAllWithStore();
            var articles = _mapper.Map<IEnumerable<Article>, IEnumerable<ArticleModel>>(result);
            
            return Ok(new
            {
                Success = true,
                TotalElements = result.Count(),
                Articles = articles
            });
        }
        
        [HttpGet("article/get/{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var result = await _articleService.GetAllByStoreId(id);
            var articles = _mapper.Map<IEnumerable<Article>, IEnumerable<ArticleModel>>(result);
            
            return Ok(new
            {
                Success = true,
                TotalElements = result.Count(),
                Articles = articles
            });
        }
    }
}