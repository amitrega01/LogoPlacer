
  
  
  <h1 id="LogoPlacer_Logo" data-uid="LogoPlacer.Logo" class="text-break">Class Logo
  </h1>
  <div class="markdown level0 summary"><p>Klasa służaca nakładaniu logo na zdjęcia z wybranego folderu</p>
</div>
  <div class="markdown level0 conceptual"></div>
  <div class="inheritance">
    <h5>Inheritance</h5>
    <div class="level0"><span class="xref">System.Object</span></div>
    <div class="level1"><span class="xref">Logo</span></div>
  </div>
  <div class="inheritedMembers">
    <h5>Inherited Members</h5>
    <div>
      <span class="xref">System.Object.ToString()</span>
    </div>
    <div>
      <span class="xref">System.Object.Equals(System.Object)</span>
    </div>
    <div>
      <span class="xref">System.Object.Equals(System.Object, System.Object)</span>
    </div>
    <div>
      <span class="xref">System.Object.ReferenceEquals(System.Object, System.Object)</span>
    </div>
    <div>
      <span class="xref">System.Object.GetHashCode()</span>
    </div>
    <div>
      <span class="xref">System.Object.GetType()</span>
    </div>
    <div>
      <span class="xref">System.Object.MemberwiseClone()</span>
    </div>
  </div>
  <h6><strong>Namespace</strong>: <a class="xref" href="LogoPlacer.html">LogoPlacer</a></h6>
  <h6><strong>Assembly</strong>: LogoPlacer.dll</h6>
  <h5 id="LogoPlacer_Logo_syntax">Syntax</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public class Logo</code></pre>
  </div>
  <h3 id="constructors">Constructors
  </h3>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/amitrega01/LogoPlacer/new/master/apiSpec/new?filename=LogoPlacer_Logo__ctor_System_String_.md&amp;value=---%0Auid%3A%20LogoPlacer.Logo.%23ctor(System.String)%0Asummary%3A%20'*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax'%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/amitrega01/LogoPlacer/blob/master/LogoPlacer/Logo.cs/#L21">View Source</a>
  </span>
  <a id="LogoPlacer_Logo__ctor_" data-uid="LogoPlacer.Logo.#ctor*"></a>
  <h4 id="LogoPlacer_Logo__ctor_System_String_" data-uid="LogoPlacer.Logo.#ctor(System.String)">Logo(String)</h4>
  <div class="markdown level1 summary"><p>Konstruktor</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public Logo(string logoPath)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">System.String</span></td>
        <td><span class="parametername">logoPath</span></td>
        <td><p>Scieżka bezwzględna do logo</p>
</td>
      </tr>
    </tbody>
  </table>
  <h3 id="methods">Methods
  </h3>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/amitrega01/LogoPlacer/new/master/apiSpec/new?filename=LogoPlacer_Logo_AddLogo_System_String_System_String_.md&amp;value=---%0Auid%3A%20LogoPlacer.Logo.AddLogo(System.String%2CSystem.String)%0Asummary%3A%20'*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax'%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/amitrega01/LogoPlacer/blob/master/LogoPlacer/Logo.cs/#L36">View Source</a>
  </span>
  <a id="LogoPlacer_Logo_AddLogo_" data-uid="LogoPlacer.Logo.AddLogo*"></a>
  <h4 id="LogoPlacer_Logo_AddLogo_System_String_System_String_" data-uid="LogoPlacer.Logo.AddLogo(System.String,System.String)">AddLogo(String, String)</h4>
  <div class="markdown level1 summary"><p>Metoda dodająca logo na konkretne zdjęcie</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public string AddLogo(string pathToPhoto, string pathToSave)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">System.String</span></td>
        <td><span class="parametername">pathToPhoto</span></td>
        <td><p>Bezwzględna ścieżka do zdjęcia  na które nakładamy logo</p>
</td>
      </tr>
      <tr>
        <td><span class="xref">System.String</span></td>
        <td><span class="parametername">pathToSave</span></td>
        <td><p>Scieżka do folderu gdzie zostanie zapisane zdjęcie z nałożonym logo</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">System.String</span></td>
        <td><p>Zwraca scieżke bezwględną do zdjęcia z nałozonym logo</p>
</td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/amitrega01/LogoPlacer/new/master/apiSpec/new?filename=LogoPlacer_Logo_GetFiles_System_String_.md&amp;value=---%0Auid%3A%20LogoPlacer.Logo.GetFiles(System.String)%0Asummary%3A%20'*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax'%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/amitrega01/LogoPlacer/blob/master/LogoPlacer/Logo.cs/#L67">View Source</a>
  </span>
  <a id="LogoPlacer_Logo_GetFiles_" data-uid="LogoPlacer.Logo.GetFiles*"></a>
  <h4 id="LogoPlacer_Logo_GetFiles_System_String_" data-uid="LogoPlacer.Logo.GetFiles(System.String)">GetFiles(String)</h4>
  <div class="markdown level1 summary"><p>Metoda zwracająca scieżki do nieobrobionych zdjęć</p>
</div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public IEnumerable&lt;string&gt; GetFiles(string path)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">System.String</span></td>
        <td><span class="parametername">path</span></td>
        <td><p>Scieżka do folderu ze zdjęciami</p>
</td>
      </tr>
    </tbody>
  </table>
  <h5 class="returns">Returns</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">System.Collections.Generic.IEnumerable</span>&lt;<span class="xref">System.String</span>&gt;</td>
        <td><p>Zwraca IEnumerble ze scieżkami bezwzględnymi do zdjęc nie obrobionych przez program</p>
</td>
      </tr>
    </tbody>
  </table>
  <span class="small pull-right mobile-hide">
    <span class="divider">|</span>
    <a href="https://github.com/amitrega01/LogoPlacer/new/master/apiSpec/new?filename=LogoPlacer_Logo_SetLogoPath_System_String_.md&amp;value=---%0Auid%3A%20LogoPlacer.Logo.SetLogoPath(System.String)%0Asummary%3A%20'*You%20can%20override%20summary%20for%20the%20API%20here%20using%20*MARKDOWN*%20syntax'%0A---%0A%0A*Please%20type%20below%20more%20information%20about%20this%20API%3A*%0A%0A">Improve this Doc</a>
  </span>
  <span class="small pull-right mobile-hide">
    <a href="https://github.com/amitrega01/LogoPlacer/blob/master/LogoPlacer/Logo.cs/#L73">View Source</a>
  </span>
  <a id="LogoPlacer_Logo_SetLogoPath_" data-uid="LogoPlacer.Logo.SetLogoPath*"></a>
  <h4 id="LogoPlacer_Logo_SetLogoPath_System_String_" data-uid="LogoPlacer.Logo.SetLogoPath(System.String)">SetLogoPath(String)</h4>
  <div class="markdown level1 summary"></div>
  <div class="markdown level1 conceptual"></div>
  <h5 class="decalaration">Declaration</h5>
  <div class="codewrapper">
    <pre><code class="lang-csharp hljs">public void SetLogoPath(string logoPath)</code></pre>
  </div>
  <h5 class="parameters">Parameters</h5>
  <table class="table table-bordered table-striped table-condensed">
    <thead>
      <tr>
        <th>Type</th>
        <th>Name</th>
        <th>Description</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><span class="xref">System.String</span></td>
        <td><span class="parametername">logoPath</span></td>
        <td></td>
      </tr>
    </tbody>
  </table>
