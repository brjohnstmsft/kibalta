namespace PaketLoadScripts

#r "C:\\Users\\brjohnst\\.nuget\\packages\\newtonsoft.json\\12.0.1\\lib\\netstandard2.0\\Newtonsoft.Json.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\taskbuilder.fs\\2.1.0\\lib\\netstandard1.6\\TaskBuilder.fs.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\microsoft.csharp\\4.5.0\\lib\\netstandard2.0\\Microsoft.CSharp.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.security.cryptography.cng\\4.5.0\\lib\\netstandard2.0\\System.Security.Cryptography.Cng.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.security.cryptography.openssl\\4.5.0\\lib\\netstandard2.0\\System.Security.Cryptography.OpenSsl.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.componentmodel.typeconverter\\4.3.0\\lib\\netstandard1.5\\System.ComponentModel.TypeConverter.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.dynamic.runtime\\4.3.0\\lib\\netstandard1.3\\System.Dynamic.Runtime.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.io.compression.zipfile\\4.3.0\\lib\\netstandard1.3\\System.IO.Compression.ZipFile.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.linq.queryable\\4.3.0\\lib\\netstandard1.3\\System.Linq.Queryable.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.xml.xdocument\\4.3.0\\lib\\netstandard1.3\\System.Xml.XDocument.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.xml.xmldocument\\4.3.0\\lib\\netstandard1.3\\System.Xml.XmlDocument.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.collections.specialized\\4.3.0\\lib\\netstandard1.3\\System.Collections.Specialized.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.linq.expressions\\4.3.0\\lib\\netstandard1.6\\System.Linq.Expressions.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.runtime.serialization.formatters\\4.3.0\\lib\\netstandard1.4\\System.Runtime.Serialization.Formatters.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.threading.tasks.parallel\\4.3.0\\lib\\netstandard1.3\\System.Threading.Tasks.Parallel.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.xml.readerwriter\\4.3.1\\lib\\netstandard1.3\\System.Xml.ReaderWriter.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.buffers\\4.5.0\\lib\\netstandard2.0\\System.Buffers.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.collections.concurrent\\4.3.0\\lib\\netstandard1.3\\System.Collections.Concurrent.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.collections.nongeneric\\4.3.0\\lib\\netstandard1.3\\System.Collections.NonGeneric.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.componentmodel.primitives\\4.3.0\\lib\\netstandard1.0\\System.ComponentModel.Primitives.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.linq\\4.3.0\\lib\\netstandard1.6\\System.Linq.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.net.webheadercollection\\4.3.0\\lib\\netstandard1.3\\System.Net.WebHeaderCollection.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.objectmodel\\4.3.0\\lib\\netstandard1.3\\System.ObjectModel.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.reflection.emit\\4.3.0\\lib\\netstandard1.3\\System.Reflection.Emit.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.reflection.emit.lightweight\\4.3.0\\lib\\netstandard1.3\\System.Reflection.Emit.Lightweight.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.reflection.typeextensions\\4.5.1\\lib\\netstandard2.0\\System.Reflection.TypeExtensions.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.runtime.interopservices.runtimeinformation\\4.3.0\\lib\\netstandard1.1\\System.Runtime.InteropServices.RuntimeInformation.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.runtime.numerics\\4.3.0\\lib\\netstandard1.3\\System.Runtime.Numerics.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.runtime.serialization.primitives\\4.3.0\\lib\\netstandard1.3\\System.Runtime.Serialization.Primitives.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.security.cryptography.primitives\\4.3.0\\lib\\netstandard1.3\\System.Security.Cryptography.Primitives.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.text.regularexpressions\\4.3.0\\lib\\netstandard1.6\\System.Text.RegularExpressions.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.diagnostics.diagnosticsource\\4.5.1\\lib\\netstandard1.3\\System.Diagnostics.DiagnosticSource.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.reflection.emit.ilgeneration\\4.3.0\\lib\\netstandard1.3\\System.Reflection.Emit.ILGeneration.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.threading\\4.3.0\\lib\\netstandard1.3\\System.Threading.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.threading.tasks.extensions\\4.5.1\\lib\\netstandard2.0\\System.Threading.Tasks.Extensions.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.threading.threadpool\\4.3.0\\lib\\netstandard1.3\\System.Threading.ThreadPool.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.appcontext\\4.3.0\\lib\\netstandard1.6\\System.AppContext.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.componentmodel\\4.3.0\\lib\\netstandard1.3\\System.ComponentModel.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.io.filesystem.primitives\\4.3.0\\lib\\netstandard1.3\\System.IO.FileSystem.Primitives.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.runtime.compilerservices.unsafe\\4.5.2\\lib\\netstandard2.0\\System.Runtime.CompilerServices.Unsafe.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\system.threading.thread\\4.3.0\\lib\\netstandard1.3\\System.Threading.Thread.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\microsoft.spatial\\7.5.2\\lib\\netstandard1.1\\Microsoft.Spatial.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\microsoft.rest.clientruntime\\2.3.18\\lib\\netstandard1.4\\Microsoft.Rest.ClientRuntime.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\microsoft.rest.clientruntime.azure\\3.3.18\\lib\\netstandard1.4\\Microsoft.Rest.ClientRuntime.Azure.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\microsoft.azure.search.common\\5.0.3\\lib\\netstandard1.4\\Microsoft.Azure.Search.Common.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\microsoft.azure.search.data\\5.0.3\\lib\\netstandard1.4\\Microsoft.Azure.Search.Data.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\microsoft.azure.search.service\\5.0.3\\lib\\netstandard1.4\\Microsoft.Azure.Search.Service.dll" 
#r "C:\\Users\\brjohnst\\.nuget\\packages\\microsoft.azure.search\\5.0.3\\lib\\netstandard1.4\\Microsoft.Azure.Search.dll" 
#r "System" 
#r "System.ComponentModel.Composition" 
#r "System.Core" 
#r "System.Runtime.Serialization" 
#r "System.Numerics" 
#r "System.Xml" 
#r "System.IO.Compression" 
#r "System.Xml.Linq" 
#r "System.IO.Compression.FileSystem" 
#r "System.Net.Http" 
#r "Microsoft.CSharp" 
#r "System.Net" 
#r "System.Net.Http.WebRequest" 
#r "System.Runtime" 