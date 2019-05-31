import Stackedit from 'stackedit-js';
 const el = document.querySelector('textarea')
 const stackedit = new Stackedit()

export default () => (
    <div>
      <p>This is the about page</p>
      {stackedit.openFile({
        name: "test",
        content: {
          text: 'text'
        }
      })}
    </div>
  )