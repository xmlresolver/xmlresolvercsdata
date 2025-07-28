using System;
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework;
using Org.XmlResolver;
using Org.XmlResolver.Features;

namespace UnitTests {
    public class DataTest : ResolverTest {
        private XmlResolverConfiguration config = null;
        private CatalogManager manager = null;

        [SetUp]
        public void Setup() {
            config = new XmlResolverConfiguration(new List<Uri>(), new List<string>());

            try {
                Assembly asm = Assembly.Load("XmlResolverData");
                config.AddAssemblyCatalog("Org.XmlResolver.catalog.xml", asm);
            }
            catch (Exception) {
                Assert.Fail();
            }

            manager = (CatalogManager) config.GetFeature(ResolverFeature.CATALOG_MANAGER);
        }

    [Test]
    public void Gen_lookupPublicd2e3() {
        Uri result = manager.LookupPublic(null, "-//XML-DEV//ENTITIES RDDL QName Module 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e4() {
        Uri result = manager.LookupSystem("http://www.rddl.org/rddl-qname-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e6() {
        Uri result = manager.LookupPublic(null, "-//XML-DEV//ELEMENTS RDDL Resource 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e7() {
        Uri result = manager.LookupSystem("http://www.rddl.org/rddl-resource-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e9() {
        Uri result = manager.LookupPublic(null, "-//XML-DEV//DTD XHTML RDDL 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e10() {
        Uri result = manager.LookupSystem("http://www.rddl.org/rddl-xhtml.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e12() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-arch-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e14() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-attribs-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e16() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-base-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e18() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-basic-form-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e20() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-basic-table-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e22() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-blkphras-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e24() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-blkstruct-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e26() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-charent-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e29() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-datatypes-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e31() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-events-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e33() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-framework-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e35() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-hypertext-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e37() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-image-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e39() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-inlphras-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e41() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-inlstruct-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e43() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-link-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e45() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-list-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e47() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-meta-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e49() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-notations-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e52() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-object-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e54() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-param-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e56() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-qname-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e58() {
        Uri result = manager.LookupPublic(null, "-//XML-DEV//ENTITIES RDDL Document Model 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e59() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-rddl-model-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e61() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-struct-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e63() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-text-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e65() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml11.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e67() {
        Uri result = manager.LookupPublic(null, "-//XML-DEV//ENTITIES XLink Module 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e68() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xlink-module-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e70() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-lat1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e72() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-special.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e74() {
        Uri result = manager.LookupSystem("http://www.rddl.org/xhtml-symbol.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e77() {
        Uri result = manager.LookupUri("http://www.w3.org/2000/09/xmldsig#");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e79() {
        Uri result = manager.LookupUri("http://www.w3.org/2009/xmldsig11#");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e81() {
        Uri result = manager.LookupUri("http://www.w3.org/2010/xmldsig2#");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e83() {
        Uri result = manager.LookupUri("https://www.w3.org/1999/xlink.xsd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e88() {
        Uri result = manager.LookupUri("https://www.w3.org/XML/2008/06/xlink.xsd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e90() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD XMLSCHEMA 200102//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e91() {
        Uri result = manager.LookupSystem("https://www.w3.org/2001/XMLSchema.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e93() {
        Uri result = manager.LookupUri("https://www.w3.org/2001/XMLSchema.xsd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e98() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD XSD 1.0 Datatypes//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e99() {
        Uri result = manager.LookupSystem("https://www.w3.org/2001/datatypes.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e101() {
        Uri result = manager.LookupUri("https://www.w3.org/2001/xml.xsd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e106() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD Specification V2.10//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e107() {
        Uri result = manager.LookupSystem("https://www.w3.org/2002/xmlspec/dtd/2.10/xmlspec.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e109() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES uppercase aliases for HTML//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e110() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/html5-uppercase.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e113() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES HTML MathML Set//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e114() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/htmlmathml-f.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e116() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES HTML MathML Set//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e117() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/htmlmathml.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e119() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Added Math Symbols: Arrow Relations//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e120() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isoamsa.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e122() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Added Math Symbols: Binary Operators//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e123() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isoamsb.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e125() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Added Math Symbols: Delimiters//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e126() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isoamsc.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e128() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Added Math Symbols: Negated Relations//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e129() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isoamsn.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e131() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Added Math Symbols: Ordinary//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e132() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isoamso.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e134() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Added Math Symbols: Relations//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e135() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isoamsr.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e137() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Box and Line Drawing//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e138() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isobox.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e140() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Russian Cyrillic//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e141() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isocyr1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e143() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Non-Russian Cyrillic//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e144() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isocyr2.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e147() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Diacritical Marks//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e148() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isodia.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e150() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Greek Letters//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e151() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isogrk1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e153() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Monotoniko Greek//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e154() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isogrk2.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e156() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Greek Symbols//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e157() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isogrk3.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e159() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Alternative Greek Symbols//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e160() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isogrk4.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e162() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Added Latin 1//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e163() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isolat1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e165() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Added Latin 2//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e166() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isolat2.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e168() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Math Alphabets: Fraktur//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e169() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isomfrk.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e171() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Math Alphabets: Open Face//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e172() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isomopf.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e174() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Math Alphabets: Script//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e175() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isomscr.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e177() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Numeric and Special Graphic//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e178() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isonum.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e181() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Publishing//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e182() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isopub.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e184() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES General Technical//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e185() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/isotech.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e187() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES MathML Aliases//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e188() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/mmlalias.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e190() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Additional MathML Symbols//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e191() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/mmlextra.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e193() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Predefined XML//EN///XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e194() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/predefined.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e196() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Combined Set//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e197() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/w3centities-f.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e199() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Combined Set//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e200() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/w3centities.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e202() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Latin for HTML//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e203() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/xhtml1-lat1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e205() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Special for HTML//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e206() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/xhtml1-special.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e208() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Symbol for HTML//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e209() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/2007/xhtml1-symbol.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e211() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Added Math Symbols: Arrow Relations//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e212() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isoamsa.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e215() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Added Math Symbols: Binary Operators//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e216() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isoamsb.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e218() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Added Math Symbols: Delimiters//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e219() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isoamsc.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e221() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Added Math Symbols: Negated Relations//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e222() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isoamsn.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e224() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Added Math Symbols: Ordinary//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e225() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isoamso.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e227() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Added Math Symbols: Relations//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e228() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isoamsr.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e230() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Box and Line Drawing//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e231() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isobox.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e233() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Russian Cyrillic//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e234() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isocyr1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e236() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Non-Russian Cyrillic//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e237() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isocyr2.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e239() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Diacritical Marks//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e240() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isodia.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e242() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Greek Letters//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e243() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isogrk1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e245() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Monotoniko Greek//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e246() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isogrk2.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e249() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Greek Symbols//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e250() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isogrk3.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e252() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Alternative Greek Symbols//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e253() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isogrk4.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e255() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Added Latin 1//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e256() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isolat1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e258() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Added Latin 2//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e259() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isolat2.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e261() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Numeric and Special Graphic//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e262() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isonum.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e264() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES Publishing//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e265() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isopub.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e267() {
        Uri result = manager.LookupPublic(null, "ISO 8879:1986//ENTITIES General Technical//EN//XML");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e268() {
        Uri result = manager.LookupSystem("https://www.w3.org/2003/entities/iso8879/isotech.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e270() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD XSD 1.1//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e271() {
        Uri result = manager.LookupSystem("https://www.w3.org/2009/XMLSchema/XMLSchema.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e272() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xmlschema11-1/XMLSchema.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e273() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xmlschema11-2/XMLSchema.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e275() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD XSD 1.1 Datatypes//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e276() {
        Uri result = manager.LookupSystem("https://www.w3.org/2009/XMLSchema/datatypes.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e277() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xmlschema11-1/datatypes.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e278() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xmlschema11-2/datatypes.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e280() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Animation//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e281() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-animation.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e283() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Animation Events Attribute//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e284() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-animevents-attrib.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e287() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Basic Clip//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e288() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-basic-clip.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e290() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Basic Filter//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e291() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-basic-filter.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e293() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Basic Font//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e294() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-basic-font.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e296() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Basic Graphics Attribute//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e297() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-basic-graphics-attrib.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e299() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Basic Paint Attribute//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e300() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-basic-paint-attrib.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e302() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Basic Structure//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e303() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-basic-structure.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e305() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Basic Text//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e306() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-basic-text.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e308() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Clip//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e309() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-clip.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e311() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Conditional Processing//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e312() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-conditional.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e314() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Container Attribute//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e315() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-container-attrib.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e317() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Core Attribute//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e318() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-core-attrib.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e321() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Cursor//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e322() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-cursor.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e324() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Datatypes//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e325() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-datatypes.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e327() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Document Events Attribute//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e328() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-docevents-attrib.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e330() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Extensibility//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e331() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-extensibility.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e333() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 External Resources Attribute//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e334() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-extresources-attrib.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e336() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Filter//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e337() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-filter.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e339() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Font//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e340() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-font.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e342() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Modular Framework//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e343() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-framework.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e345() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Gradient//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e346() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-gradient.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e348() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Graphical Element Events Attribute//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e349() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-graphevents-attrib.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e351() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Graphics Attribute//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e352() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-graphics-attrib.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e355() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Hyperlinking//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e356() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-hyperlink.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e358() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Image//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e359() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-image.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e361() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Marker//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e362() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-marker.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e364() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Mask//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e365() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-mask.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e367() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Paint Opacity Attribute//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e368() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-opacity-attrib.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e370() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Paint Attribute//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e371() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-paint-attrib.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e373() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Pattern//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e374() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-pattern.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e376() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Color Profile//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e377() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-profile.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e379() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Qualified Name//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e380() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-qname.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e382() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Scripting//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e383() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-script.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e385() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Shape//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e386() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-shape.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e389() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Structure//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e390() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-structure.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e392() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Style//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e393() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-style.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e395() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG Template Qualified Name//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e396() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-template-qname.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e398() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-template.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e400() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 Text//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e401() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-text.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e403() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS SVG 1.1 View//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e404() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-view.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e406() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Viewport Attribute//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e407() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-viewport-attrib.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e409() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 XLink Attribute//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e410() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg-xlink-attrib.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e412() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Attribute Collection//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e413() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg11-attribs.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e415() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Basic Attribute Collection//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e416() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg11-basic-attribs.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e418() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg11-basic-flat.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e421() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Basic Document Model//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e422() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg11-basic-model.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e424() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD SVG 1.1 Basic//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e425() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg11-basic.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e427() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg11-flat-20030114.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e429() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg11-flat.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e431() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Document Model//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e432() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg11-model.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e434() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD SVG 1.1 Template//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e435() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg11-template.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e437() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Tiny Attribute Collection//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e438() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg11-tiny-attribs.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e440() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg11-tiny-flat.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e442() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES SVG 1.1 Tiny Document Model//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e443() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg11-tiny-model.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e445() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD SVG 1.1 Tiny//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e446() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg11-tiny.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e448() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD SVG 1.1//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e449() {
        Uri result = manager.LookupSystem("https://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e452() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Access Element 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e453() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-access-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e455() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML Access Attribute Qnames 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e456() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-access-qname-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e458() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Java Applets 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e459() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-applet-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e461() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Base Architecture 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e462() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-arch-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e464() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML Common Attributes 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e465() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-attribs-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e467() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Base Element 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e468() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-base-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e470() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Basic Forms 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e471() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-basic-form-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e473() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Basic Tables 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e474() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-basic-table-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e476() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML Basic 1.0 Document Model 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e477() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-basic10-model-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e479() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML Basic 1.1 Document Model 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e480() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-basic11-model-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e482() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD XHTML Basic 1.1//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e483() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-basic11.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e486() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML BIDI Override Element 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e487() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-bdo-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e489() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Block Phrasal 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e490() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-blkphras-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e492() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Block Presentation 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e493() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-blkpres-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e495() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Block Structural 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e496() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-blkstruct-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e498() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML Character Entities 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e499() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-charent-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e501() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Client-side Image Maps 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e502() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-csismap-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e504() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML Datatypes 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e505() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-datatypes-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e507() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Editing Elements 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e508() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-edit-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e510() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML Intrinsic Events 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e511() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-events-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e513() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Forms 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e514() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-form-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e516() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Frames 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e517() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-frames-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e520() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML Modular Framework 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e521() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-framework-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e523() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML HyperAttributes 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e524() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-hyperAttributes-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e526() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Hypertext 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e527() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-hypertext-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e529() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Inline Frame Element 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e530() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-iframe-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e532() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Images 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e533() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-image-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e535() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Inline Phrasal 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e536() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-inlphras-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e538() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Inline Presentation 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e539() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-inlpres-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e541() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Inline Structural 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e542() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-inlstruct-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e544() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Inline Style 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e545() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-inlstyle-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e547() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Inputmode 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e548() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-inputmode-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e550() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-lat1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e553() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Legacy MarkUp 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e554() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-legacy-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e556() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Legacy Redeclarations 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e557() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-legacy-redecl-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e559() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Link Element 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e560() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-link-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e562() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Lists 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e563() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-list-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e565() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Metainformation 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e566() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-meta-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e568() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Metainformation 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e569() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-meta-2.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e571() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML MetaAttributes 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e572() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-metaAttributes-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e574() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Name Identifier 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e575() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-nameident-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e577() {
        Uri result = manager.LookupPublic(null, "-//W3C//NOTATIONS XHTML Notations 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e578() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-notations-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e580() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Embedded Object 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e581() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-object-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e583() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Param Element 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e584() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-param-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e587() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Presentation 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e588() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-pres-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e590() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML-Print 1.0 Document Model 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e591() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-print10-model-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e593() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML Qualified Names 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e594() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-qname-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e596() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML+RDFa Document Model 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e597() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-rdfa-model-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e599() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML RDFa Attribute Qnames 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e600() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-rdfa-qname-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e602() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML Role Attribute 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e603() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-role-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e605() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML Role Attribute Qnames 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e606() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-role-qname-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e608() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Ruby 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e609() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-ruby-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e611() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Scripting 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e612() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-script-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e614() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-special.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e616() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Server-side Image Maps 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e617() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-ssismap-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e620() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Document Structure 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e621() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-struct-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e623() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Style Sheets 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e624() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-style-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e626() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-symbol.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e628() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Tables 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e629() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-table-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e631() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Target 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e632() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-target-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e634() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Text 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e635() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml-text-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e637() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD XHTML 1.0 Frameset//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e638() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml1-frameset.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e640() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD XHTML 1.0 Strict//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e641() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml1-strict.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e643() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD XHTML 1.0 Transitional//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e644() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml1-transitional.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e646() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES XHTML 1.1 Document Model 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e647() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml11-model-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e649() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD XHTML 1.1//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e650() {
        Uri result = manager.LookupSystem("https://www.w3.org/MarkUp/DTD/xhtml11.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e653() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isoamsa.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e655() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isoamsb.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e657() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isoamsc.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e659() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isoamsn.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e661() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isoamso.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e663() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isoamsr.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e665() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isobox.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e667() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isocyr1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e669() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isocyr2.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e671() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isodia.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e673() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isogrk1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e676() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isogrk2.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e678() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isogrk3.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e680() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isogrk4.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e682() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isolat1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e684() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isolat2.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e686() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isomfrk.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e688() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isomopf.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e690() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isomscr.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e692() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isonum.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e694() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isopub.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e696() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/isotech.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e699() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/mathml.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e701() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/mmlalias.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e703() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml1/mmlextra.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e705() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/html/lat1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e707() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/html/special.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e709() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/html/symbol.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e711() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isoamsa.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e713() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isoamsb.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e715() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isoamsc.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e717() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isoamsn.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e719() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isoamso.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e722() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isoamsr.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e724() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Box and Line Drawing for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e725() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isobox.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e727() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Russian Cyrillic for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e728() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isocyr1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e730() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Non-Russian Cyrillic for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e731() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isocyr2.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e733() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Diacritical Marks for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e734() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isodia.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e736() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isogrk1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e738() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isogrk2.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e740() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isogrk3.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e742() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isogrk4.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e744() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Added Latin 1 for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e745() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isolat1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e747() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Added Latin 2 for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e748() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isolat2.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e751() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Numeric and Special Graphic for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e752() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isonum.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e754() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Publishing for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e755() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isopub.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e757() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso8879/isotech.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e759() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Added Math Symbols: Arrow Relations for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e760() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso9573-13/isoamsa.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e762() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Added Math Symbols: Binary Operators for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e763() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso9573-13/isoamsb.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e765() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Added Math Symbols: Delimiters for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e766() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso9573-13/isoamsc.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e768() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Added Math Symbols: Negated Relations for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e769() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso9573-13/isoamsn.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e771() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Added Math Symbols: Ordinary for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e772() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso9573-13/isoamso.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e774() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Added Math Symbols: Relations for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e775() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso9573-13/isoamsr.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e777() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Greek Symbols for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e778() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso9573-13/isogrk3.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e780() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso9573-13/isogrk4.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e783() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Math Alphabets: Fraktur for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e784() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso9573-13/isomfrk.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e786() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Math Alphabets: Open Face for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e787() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso9573-13/isomopf.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e789() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Math Alphabets: Script for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e790() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso9573-13/isomscr.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e792() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES General Technical for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e793() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/iso9573-13/isotech.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e795() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isoamsa.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e797() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isoamsb.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e799() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isoamsc.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e801() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isoamsn.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e803() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isoamso.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e805() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isoamsr.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e807() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isobox.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e810() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isocyr1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e812() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isocyr2.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e814() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isodia.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e816() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isogrk3.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e818() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isolat1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e820() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isolat2.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e822() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isomfrk.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e824() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isomopf.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e826() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isomscr.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e828() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isonum.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e830() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isopub.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e833() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/isotech.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e835() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Aliases for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e836() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/mathml/mmlalias.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e838() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Extra for MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e839() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/mathml/mmlextra.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e841() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/mathml2-a.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e843() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES MathML 2.0 Qualified Names 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e844() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/mathml2-qname-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e846() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD MathML 2.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e847() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/mathml2.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e849() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/mmlalias.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e851() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/mmlextra.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e853() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/xhtml-math11-f-a.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e855() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/xhtml-math11-f.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e857() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml2/xhtml-math11.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e860() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isoamsa.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e862() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isoamsb.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e864() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isoamsc.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e866() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isoamsn.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e868() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isoamso.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e870() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isoamsr.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e872() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isobox.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e874() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isocyr1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e876() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isocyr2.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e878() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isodia.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e880() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isogrk3.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e883() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isolat1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e885() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isolat2.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e887() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isomfrk.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e889() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isomopf.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e891() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isomscr.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e893() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isonum.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e895() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isopub.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e897() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/isotech.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e899() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES MathML 3.0 Qualified Names 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e900() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/mathml3-qname.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e902() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/mathml3.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e904() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/mmlalias.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e907() {
        Uri result = manager.LookupSystem("https://www.w3.org/Math/DTD/mathml3/mmlextra.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e909() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD SVG 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e910() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/2001/REC-SVG-20010904/DTD/svg10.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e912() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Ruby 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e913() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/ruby/xhtml-ruby-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e915() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD XHTML Basic 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e916() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xhtml-basic/xhtml-basic10.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e918() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML BIDI Override Element 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e919() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xhtml-modularization/DTD/xhtml-bdo-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e921() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Client-side Image Maps 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e922() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xhtml-modularization/DTD/xhtml-csismap-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e924() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Editing Elements 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e925() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xhtml-modularization/DTD/xhtml-edit-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e927() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Legacy MarkUp 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e928() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xhtml-modularization/DTD/xhtml-legacy-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e930() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Server-side Image Maps 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e931() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xhtml-modularization/DTD/xhtml-ssismap-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e933() {
        Uri result = manager.LookupPublic(null, "-//W3C//ELEMENTS XHTML Tables 1.0//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e934() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xhtml-modularization/DTD/xhtml-table-1.mod");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e936() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Latin 1 for XHTML//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e937() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xhtml-modularization/DTD/xhtml-lat1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e940() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Symbols for XHTML//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e941() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xhtml-modularization/DTD/xhtml-special.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e943() {
        Uri result = manager.LookupPublic(null, "-//W3C//ENTITIES Special for XHTML//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e944() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xhtml-modularization/DTD/xhtml-symbol.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e946() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xhtml1/DTD/xhtml-lat1.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e948() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xhtml1/DTD/xhtml-special.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e950() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xhtml1/DTD/xhtml-symbol.ent");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e952() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD XHTML 1.0 Frameset//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e953() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xhtml1/DTD/xhtml1-frameset.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e955() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD XHTML 1.0 Strict//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e956() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e958() {
        Uri result = manager.LookupPublic(null, "-//W3C//DTD XHTML 1.0 Transitional//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e959() {
        Uri result = manager.LookupSystem("https://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e961() {
        Uri result = manager.LookupUri("https://www.w3.org/TR/xmlschema-1/XMLSchema.xsd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e963() {
        Uri result = manager.LookupUri("https://www.w3.org/TR/xmlschema-2/datatypes.xsd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e965() {
        Uri result = manager.LookupUri("https://www.w3.org/TR/xmlschema11-1/XMLSchema.xsd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e968() {
        Uri result = manager.LookupUri("https://www.w3.org/TR/xmlschema11-2/datatypes.xsd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e970() {
        Uri result = manager.LookupUri("https://www.w3.org/TR/xslt-30/schema-for-json.xsd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e972() {
        Uri result = manager.LookupUri("https://www.w3.org/TR/xslt-30/schema-for-xslt30.rnc");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e974() {
        Uri result = manager.LookupUri("https://www.w3.org/TR/xslt-30/schema-for-xslt30.rng");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e976() {
        Uri result = manager.LookupUri("https://www.w3.org/TR/xslt-30/schema-for-xslt30.xsd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e978() {
        Uri result = manager.LookupUri("https://www.w3.org/TR/xslt-30/xml-to-json.xsl");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e980() {
        Uri result = manager.LookupUri("https://www.w3.org/2007/schema-for-xslt20.xsd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e982() {
        Uri result = manager.LookupUri("https://xmlcatalogs.org/schema/1.1/catalog.xsd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e983() {
        Uri result = manager.LookupUri("http://www.oasis-open.org/committees/entity/release/1.1/catalog.xsd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e988() {
        Uri result = manager.LookupUri("https://xmlcatalogs.org/schema/1.1/catalog.rnc");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e990() {
        Uri result = manager.LookupUri("https://xmlcatalogs.org/schema/1.1/catalog.rng");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e991() {
        Uri result = manager.LookupUri("http://www.oasis-open.org/committees/entity/release/1.1/catalog.rng");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupPublicd2e996() {
        Uri result = manager.LookupPublic(null, "-//OASIS//DTD XML Catalogs V1.1//EN");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e997() {
        Uri result = manager.LookupSystem("https://xmlcatalogs.org/schema/1.1/catalog.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupSystemd2e998() {
        Uri result = manager.LookupSystem("http://www.oasis-open.org/committees/entity/release/1.1/catalog.dtd");
        Assert.NotNull(result);
    }

    [Test]
    public void Gen_lookupUrid2e1004() {
        Uri result = manager.LookupUri("https://xmlresolver.org/data/resolver/succeeded/test/check.xml");
        Assert.NotNull(result);
    }

  }
}
