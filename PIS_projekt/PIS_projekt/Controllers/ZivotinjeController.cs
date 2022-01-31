﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PIS_projekt.Models;
using PIS_projekt.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIS_projekt.Controllers
{
    public class ZivotinjeController : Controller
    {
        private readonly LutaliceInfoSustavContext ctx;
        public ZivotinjeController(LutaliceInfoSustavContext ctx)
        {
            this.ctx = ctx;
        }
        public IActionResult Pronadjene(int pg = 1)
        {
            var query = ctx.ZivotinjaUSklonistus
                .Select(z => new ZivotinjeMiniViewModel
                {
                    ZivotinjaUSklonistuId = z.ZivotinjaUSklonistuId,
                    SklonisteId = z.SklonisteId,
                    BrojMikrocipa = z.BrojMikrocipa,
                    ImeZivotinje = z.ImeZivotinje,
                    NazivPasmine = z.Pasmina.NazivPasmine,
                    NazivVrste = z.Pasmina.VrstaZivotinje.NazivVrste,
                    NazivSpola = z.Spol.NazivSpola,
                   // DatumStenjenja = z.DatumStenjenja,
                   // Slika = z.Slika,
                    JeLiZaUdomljavanje = z.Udomljavanje.JeLiZaUdomljavanje,
                    //AdresaPronalaska= z.AdresaPronalaska,
                    //DatumPronalaska = z.DatumPronalaska,
                    NazivSklonista = z.Skloniste.NazivSklonista,
                   // Adresa = z.Skloniste.Adresa,
                    NazivGrada = z.Skloniste.Grad.NazivGrada,
                   // NazivZupanije = z.Skloniste.Grad.Zupanija.NazivZupanije*/
                })
                .ToList();

            const int pageSize = 5;
            if (pg < 1)
            {
                pg = 1;
            }

            int recsCount = query.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = query.Skip(recSkip).Take(pager.PageSize).ToList();
            var model = new ZivotinjeMiniVM
            {
                ZivotinjeMini = data
            };
            this.ViewBag.Pager = pager;

            
            return View("Index",model);
        }
        public IActionResult ZaUdomljavanje(int pg = 1)
        {
            var query = ctx.ZivotinjaUSklonistus
                .Where(z=>z.UdomljavanjeId == 1)
                .Select(z => new ZivotinjeMiniViewModel
                {
                    ZivotinjaUSklonistuId = z.ZivotinjaUSklonistuId,
                    BrojMikrocipa = z.BrojMikrocipa,
                    ImeZivotinje = z.ImeZivotinje,
                    NazivPasmine = z.Pasmina.NazivPasmine,
                    NazivVrste = z.Pasmina.VrstaZivotinje.NazivVrste,
                    NazivSpola = z.Spol.NazivSpola,
                    //DatumStenjenja = z.DatumStenjenja,
                    //Slika = z.Slika,
                    JeLiZaUdomljavanje = z.Udomljavanje.JeLiZaUdomljavanje,
                    //AdresaPronalaska = z.AdresaPronalaska,
                    //DatumPronalaska = z.DatumPronalaska,
                    NazivSklonista = z.Skloniste.NazivSklonista,
                    //Adresa = z.Skloniste.Adresa,
                    NazivGrada = z.Skloniste.Grad.NazivGrada,
                   // NazivZupanije = z.Skloniste.Grad.Zupanija.NazivZupanije*/
                })
                .ToList();
            const int pageSize = 2;
            if (pg < 1)
            {
                pg = 1;
            }

            int recsCount = query.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = query.Skip(recSkip).Take(pager.PageSize).ToList();
            var model = new ZivotinjeMiniVM
            {
                ZivotinjeMini = data
            };
            this.ViewBag.Pager = pager;
            return View("ZaUdomljavanje", model);
        }
        public IActionResult Detalji(int id)
        {
            var query = ctx.ZivotinjaUSklonistus
                .Where(z => z.ZivotinjaUSklonistuId == id)
                .Select(z => new ZivotinjeViewModel
                {
                    ZivotinjaUSklonistuId = z.ZivotinjaUSklonistuId,
                    BrojMikrocipa = z.BrojMikrocipa,
                    ImeZivotinje = z.ImeZivotinje,
                    NazivPasmine = z.Pasmina.NazivPasmine,
                    NazivVrste = z.Pasmina.VrstaZivotinje.NazivVrste,
                    NazivSpola = z.Spol.NazivSpola,
                    DatumStenjenja = z.DatumStenjenja,
                    Slika = z.Slika,
                    JeLiZaUdomljavanje = z.Udomljavanje.JeLiZaUdomljavanje,
                    AdresaPronalaska = z.AdresaPronalaska,
                    DatumPronalaska = z.DatumPronalaska,
                    NazivSklonista = z.Skloniste.NazivSklonista,
                    //Adresa = z.Skloniste.Adresa,
                    NazivGrada = z.Skloniste.Grad.NazivGrada,
                   // NazivZupanije = z.Skloniste.Grad.Zupanija.NazivZupanije*/
                })
                .ToList();
            var model = new ZivotinjeVM
            {
                zivotinje = query
            };
            return View("Detalji", model);
        }
        public IActionResult Izgubljene(int pg=1)
        {
            var query = ctx.IzgubljeneZivotinjes
                .Select(iz => new IzgubljeneMiniViewModel
                {
                    IzgubljeneZivotinjeId = iz.IzgubljeneZivotinjeId,
                    VrstaZivotinje = iz.Pasmina.VrstaZivotinje.NazivVrste,
                    Pasmina = iz.Pasmina.NazivPasmine,
                    Spol = iz.Spol.NazivSpola,
                    Kontakt = iz.Kontakt,
                    LokacijaNestanka = iz.LokacijaNestanka,
                    Grad = iz.Grad.NazivGrada,
                    DatumNestanka = iz.DatumNestanka,
                    DatumPrijave = iz.DatumPrijave
                })
                .ToList();
            const int pageSize = 1;
            if (pg < 1)
            {
                pg = 1;
            }

            int recsCount = query.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = query.Skip(recSkip).Take(pager.PageSize).ToList();
            var model = new IzgubljeneMiniVM
            {
                IzgubljeneMini = data
            };
            this.ViewBag.Pager = pager;
            return View("Izgubljene", model);
        }
        public IActionResult IzgubljeneDetalji(int id)
        {
            var query = ctx.IzgubljeneZivotinjes
                .Where(iz => iz.IzgubljeneZivotinjeId == id)
                .Select(iz => new IzgubljeneViewModel
                {
                    IzgubljeneZivotinjeId = iz.IzgubljeneZivotinjeId,
                    BrojMikrocipa = iz.BrojMikrocipa,
                    Ime = iz.Ime,
                    Pasmina = iz.Pasmina.NazivPasmine,
                    VrstaZivotinje = iz.VrstaZivotinje.NazivVrste,
                    Spol = iz.Spol.NazivSpola,
                    Kastrat = iz.Kastrat.JeLiKastrat,
                    Slika = iz.Slika,
                    LokacijaNestanka = iz.LokacijaNestanka,
                    Grad = iz.Grad.NazivGrada,
                    DatumNestanka = iz.DatumNestanka,
                    DatumPrijave = iz.DatumPrijave,
                    Kontakt = iz.Kontakt
                })
                .ToList();

            var model = new IzgubljeneVM
            {
                izgubljene = query
            };
            return View("IzgubljeneDetalji", model);
        }
        public IActionResult ZivotinjeUSklonistu(int pg=1)
        {
            var logiraniKorisnik = ctx.Korisniks
                .Where(k => k.KorisnikId == HttpContext.Session.GetInt32("idLogiranogKorisnika"))
                .FirstOrDefault<Korisnik>();
            var skloniste = ctx.Sklonistes
                .Where(s => s.SklonisteId == logiraniKorisnik.SklonisteFk)
                .FirstOrDefault<Skloniste>();
            ViewBag.ID = skloniste.SklonisteId;
            if (skloniste != null)
            {
                var query = ctx.ZivotinjaUSklonistus
                .Where(z => z.SklonisteId == skloniste.SklonisteId)
                .Select(z => new ZivotinjeMiniViewModel
                {
                    ZivotinjaUSklonistuId = z.ZivotinjaUSklonistuId,
                    BrojMikrocipa = z.BrojMikrocipa,
                    ImeZivotinje = z.ImeZivotinje,
                    NazivPasmine = z.Pasmina.NazivPasmine,
                    NazivVrste = z.Pasmina.VrstaZivotinje.NazivVrste,
                    NazivSpola = z.Spol.NazivSpola,
                    //DatumStenjenja = z.DatumStenjenja,
                    //Slika = z.Slika,
                    JeLiZaUdomljavanje = z.Udomljavanje.JeLiZaUdomljavanje,
                    //AdresaPronalaska = z.AdresaPronalaska,
                    //DatumPronalaska = z.DatumPronalaska,
                    NazivSklonista = z.Skloniste.NazivSklonista,
                    //Adresa = z.Skloniste.Adresa,
                    NazivGrada = z.Skloniste.Grad.NazivGrada,
                    // NazivZupanije = z.Skloniste.Grad.Zupanija.NazivZupanije*/
                })
                .ToList();
                
            
                const int pageSize = 2;
                if (pg < 1)
                {
                    pg = 1;
                }

                int recsCount = query.Count();
                var pager = new Pager(recsCount, pg, pageSize);
                int recSkip = (pg - 1) * pageSize;
                var data = query.Skip(recSkip).Take(pager.PageSize).ToList();
                var model = new ZivotinjeMiniVM
                {
                    ZivotinjeMini = data
                };
                this.ViewBag.Pager = pager;
                return View("ZivotinjeUSklonistu", model);
            }
            else
            {
                return Ok("problemi, problemi");
            }
            

         }
        public IActionResult UoceneLutalice(int pg = 1)
        {
            var zaposlenik = ctx.Korisniks
                .Where(k => k.KorisnikId == HttpContext.Session.GetInt32("idLogiranogKorisnika"))
                .Where(k=>k.Ime == HttpContext.Session.GetString("imeLogiranogKorisnika"))
                .FirstOrDefault<Korisnik>();
            
            var skloniste = ctx.Sklonistes
                .Where(s => s.SklonisteId == zaposlenik.SklonisteFk)
                .FirstOrDefault<Skloniste>();
            
            
            var grad = ctx.Grads
                .Where(g => g.GradId == skloniste.GradId)
                .FirstOrDefault<Grad>();
            
            var query = ctx.UoceneLutalices
                .Where(ul => ul.GradId == grad.GradId)
                .ToList();
            
            const int pageSize = 2;
            if (pg < 1)
            {
                pg = 1;
            }

            int recsCount = query.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = query.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;
            return View("PrijavljeneLutalice", data);
        }
        public IActionResult ZaUdomljavanjeSkloniste(int pg=1)
        {
            var logiraniKorisnik = ctx.Korisniks
                .Where(k => k.KorisnikId == HttpContext.Session.GetInt32("idLogiranogKorisnika"))
                .FirstOrDefault<Korisnik>();
            var skloniste = ctx.Sklonistes
                .Where(s => s.SklonisteId == logiraniKorisnik.SklonisteFk)
                .FirstOrDefault<Skloniste>();
            ViewBag.ID = skloniste.SklonisteId;
            if (skloniste != null)
            {
                var query = ctx.ZivotinjaUSklonistus
                .Where(z => z.SklonisteId == skloniste.SklonisteId)
                .Where(z=>z.UdomljavanjeId == 1)
                .Select(z => new ZivotinjeMiniViewModel
                {
                    ZivotinjaUSklonistuId = z.ZivotinjaUSklonistuId,
                    BrojMikrocipa = z.BrojMikrocipa,
                    ImeZivotinje = z.ImeZivotinje,
                    NazivPasmine = z.Pasmina.NazivPasmine,
                    NazivVrste = z.Pasmina.VrstaZivotinje.NazivVrste,
                    NazivSpola = z.Spol.NazivSpola,
                    //DatumStenjenja = z.DatumStenjenja,
                    //Slika = z.Slika,
                    JeLiZaUdomljavanje = z.Udomljavanje.JeLiZaUdomljavanje,
                    //AdresaPronalaska = z.AdresaPronalaska,
                    //DatumPronalaska = z.DatumPronalaska,
                    NazivSklonista = z.Skloniste.NazivSklonista,
                    //Adresa = z.Skloniste.Adresa,
                    NazivGrada = z.Skloniste.Grad.NazivGrada,
                    // NazivZupanije = z.Skloniste.Grad.Zupanija.NazivZupanije*/
                })
                .ToList();


                const int pageSize = 2;
                if (pg < 1)
                {
                    pg = 1;
                }

                int recsCount = query.Count();
                var pager = new Pager(recsCount, pg, pageSize);
                int recSkip = (pg - 1) * pageSize;
                var data = query.Skip(recSkip).Take(pager.PageSize).ToList();
                var model = new ZivotinjeMiniVM
                {
                    ZivotinjeMini = data
                };
                this.ViewBag.Pager = pager;
                return View("ZivotinjeUSklonistu", model);
            }
            else
            {
                return Ok("problemi, problemi");
            }
        }
        public IActionResult IzgubljeneSkloniste(int pg = 1)
        {
            var logiraniKorisnik = ctx.Korisniks
                   .Where(k => k.KorisnikId == HttpContext.Session.GetInt32("idLogiranogKorisnika"))
                   .FirstOrDefault<Korisnik>();
            var skloniste = ctx.Sklonistes
                .Where(s => s.SklonisteId == logiraniKorisnik.SklonisteFk)
                .FirstOrDefault<Skloniste>();
            ViewBag.ID = skloniste.SklonisteId;
            var query = ctx.IzgubljeneZivotinjes
                .Where(iz=>iz.GradId == skloniste.GradId)
                .Select(iz => new IzgubljeneMiniViewModel
                {
                    IzgubljeneZivotinjeId = iz.IzgubljeneZivotinjeId,
                    VrstaZivotinje = iz.Pasmina.VrstaZivotinje.NazivVrste,
                    Pasmina = iz.Pasmina.NazivPasmine,
                    Spol = iz.Spol.NazivSpola,
                    Kontakt = iz.Kontakt,
                    LokacijaNestanka = iz.LokacijaNestanka,
                    Grad = iz.Grad.NazivGrada,
                    DatumNestanka = iz.DatumNestanka,
                    DatumPrijave = iz.DatumPrijave
                })
                .ToList();
            const int pageSize = 1;
            if (pg < 1)
            {
                pg = 1;
            }

            int recsCount = query.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = query.Skip(recSkip).Take(pager.PageSize).ToList();
            var model = new IzgubljeneMiniVM
            {
                IzgubljeneMini = data
            };
            this.ViewBag.Pager = pager;
            return View("IzgubljeneSkloniste", model);
        }
        public IActionResult IzgubljeneDetaljiSkloniste(int id)
        {
            var query = ctx.IzgubljeneZivotinjes
                .Where(iz => iz.IzgubljeneZivotinjeId == id)
                .Select(iz => new IzgubljeneViewModel
                {
                    IzgubljeneZivotinjeId = iz.IzgubljeneZivotinjeId,
                    BrojMikrocipa = iz.BrojMikrocipa,
                    Ime = iz.Ime,
                    Pasmina = iz.Pasmina.NazivPasmine,
                    VrstaZivotinje = iz.VrstaZivotinje.NazivVrste,
                    Spol = iz.Spol.NazivSpola,
                    Kastrat = iz.Kastrat.JeLiKastrat,
                    Slika = iz.Slika,
                    LokacijaNestanka = iz.LokacijaNestanka,
                    Grad = iz.Grad.NazivGrada,
                    DatumNestanka = iz.DatumNestanka,
                    DatumPrijave = iz.DatumPrijave,
                    Kontakt = iz.Kontakt
                })
                .ToList();

            var model = new IzgubljeneVM
            {
                izgubljene = query
            };
            return View("izgubljeneDetaljiSkloniste", model);
        }
    }
}
