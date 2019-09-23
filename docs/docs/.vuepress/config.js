module.exports = {
    base: '/StreamCompanion/',
    title: 'osu!StreamCompanion',
    description: 'StreamCompanion documentation',
    plugins: ['@vuepress/last-updated'],
    themeConfig: {
        nav: [
            { text: 'Home', link: '/' },
            { text: 'Download', link: 'https://github.com/Piotrekol/StreamCompanion/releases/latest' }
        ],
        sidebar: [
            {
                title: 'Home',   // required
                path: '/',      // optional, which should be a absolute path.
                collapsable: true, // optional, defaults to true
                sidebarDepth: 2,    // optional, defaults to 1
                children: []
            },
            {
                title: 'Basic',
                collapsable: false,
                sidebarDepth: 2,
                children: [
                    '/basic/Installation',
                    '/basic/CreatingOutputs',
                    '/basic/LiveVisualizer',
                    '/basic/ClickCounter',
                    '/basic/ModImageGenerator',
                    '/basic/AdditionalPlugins',
                ]
            },
            {
                title: 'Development',
                collapsable: true,
                sidebarDepth: 2,
                children: [
                    'dev/',
                    'dev/Environment',
                    'dev/Compiling',
                    'dev/CustomOutputs',
                    'dev/WritingPlugins',
                ]
            }
        ],
        lastUpdated: 'Last Updated', // string | boolean
        // Assumes GitHub. Can also be a full GitLab url.
        repo: 'Piotrekol/StreamCompanion',
        // Customising the header label
        // Defaults to "GitHub"/"GitLab"/"Bitbucket" depending on `themeConfig.repo`
        repoLabel: 'Contribute!',
        // if your docs are not at the root of the repo:
        docsDir: 'docs/docs',
        // if your docs are in a specific branch (defaults to 'master'):
        docsBranch: 'master',
        // defaults to false, set to true to enable
        editLinks: true,
        // default value is true. Allows to hide next page links on all pages
        nextLinks: true,
        // default value is true. Allows to hide prev page links on all pages
        prevLinks: true,
        // custom text for edit link. Defaults to "Edit this page"
        editLinkText: 'Help us improve this page!'
    }
}