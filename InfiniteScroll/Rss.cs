using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InfiniteScroll
{

	[XmlRoot(ElementName="link", Namespace="http://www.w3.org/2005/Atom")]
	public class Link {
		[XmlAttribute(AttributeName="href")]
		public string Href { get; set; }
		[XmlAttribute(AttributeName="rel")]
		public string Rel { get; set; }
		[XmlAttribute(AttributeName="length")]
		public string Length { get; set; }
		[XmlAttribute(AttributeName="type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName="author", Namespace="http://www.w3.org/2005/Atom")]
	public class Author {
		[XmlElement(ElementName="name", Namespace="http://www.w3.org/2005/Atom")]
		public string Name { get; set; }
	}

	[XmlRoot(ElementName="summary", Namespace="http://www.w3.org/2005/Atom")]
	public class Summary {
		[XmlAttribute(AttributeName="type")]
		public string Type { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName="category", Namespace="http://www.w3.org/2005/Atom")]
	public class Category {
		[XmlAttribute(AttributeName="term")]
		public string Term { get; set; }
	}

	[XmlRoot(ElementName="entry", Namespace="http://www.w3.org/2005/Atom")]
	public class Entry {
		[XmlElement(ElementName="title", Namespace="http://www.w3.org/2005/Atom")]
		public string Title { get; set; }
		[XmlElement(ElementName="link", Namespace="http://www.w3.org/2005/Atom")]
		public List<Link> Link { get; set; }
		[XmlElement(ElementName="updated", Namespace="http://www.w3.org/2005/Atom")]
		public string Updated { get; set; }
		[XmlElement(ElementName="author", Namespace="http://www.w3.org/2005/Atom")]
		public Author Author { get; set; }
		[XmlElement(ElementName="id", Namespace="http://www.w3.org/2005/Atom")]
		public string Id { get; set; }
		[XmlElement(ElementName="summary", Namespace="http://www.w3.org/2005/Atom")]
		public Summary Summary { get; set; }
		[XmlElement(ElementName="category", Namespace="http://www.w3.org/2005/Atom")]
		public Category Category { get; set; }
	}

	[XmlRoot(ElementName="feed", Namespace="http://www.w3.org/2005/Atom")]
	public class Feed {
		[XmlElement(ElementName="title", Namespace="http://www.w3.org/2005/Atom")]
		public string Title { get; set; }
		[XmlElement(ElementName="link", Namespace="http://www.w3.org/2005/Atom")]
		public List<Link> Link { get; set; }
		[XmlElement(ElementName="id", Namespace="http://www.w3.org/2005/Atom")]
		public string Id { get; set; }
		[XmlElement(ElementName="updated", Namespace="http://www.w3.org/2005/Atom")]
		public string Updated { get; set; }
		[XmlElement(ElementName="entry", Namespace="http://www.w3.org/2005/Atom")]
		public List<Entry> Entry { get; set; }
		[XmlAttribute(AttributeName="xmlns")]
		public string Xmlns { get; set; }
		[XmlAttribute(AttributeName="lang", Namespace="http://www.w3.org/XML/1998/namespace")]
		public string Lang { get; set; }
	}

}


